using System;
using System.Linq;
using System.Xml.Linq;
using iSAMS.BatchAPI.Demo.Core.Services.Interfaces;

namespace iSAMS.BatchAPI.Demo.Core.Services.Implementations
{
    /// <summary>
    /// Service to process XML filters for an API request.
    /// </summary>
    public class FiltersXmlService : IFiltersXmlService
    {
        /// <summary>
        /// Adds or updates a filter value in the supplied XML filters.
        /// </summary>
        /// <param name="module">The module containing the filter to add or update.</param>
        /// <param name="method">The method containing the filter to add or update.</param>
        /// <param name="filter">The filter to add or update.</param>
        /// <param name="value">The filter value to add or update.</param>
        /// <param name="currentFiltersText">The XML filters.</param>
        /// <returns>
        /// The updated filter XML as a string.
        /// </returns>
        public string AddUpdateFilter(string module, string method, string filter, string value, string currentFiltersText)
        {
            if (string.IsNullOrWhiteSpace(module) || string.IsNullOrWhiteSpace(method) ||
                string.IsNullOrWhiteSpace(filter) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Error adding Filter: Values must be provided for Module, Method, Filter and Value");
            }

            var xmlDocument = !string.IsNullOrWhiteSpace(currentFiltersText)
                ? XDocument.Parse(currentFiltersText)
                : new XDocument(new XElement("Filters"));

            if (xmlDocument.Declaration == null)
            {
                xmlDocument.Declaration = new XDeclaration("1.0", "UTF-8", null);
            }

            var root = xmlDocument.Elements("Filters").SingleOrDefault();

            if (root == null)
            {
                root = new XElement("Filters");
                xmlDocument.Add(root);
            }

            var moduleNode = root.Elements(module).SingleOrDefault();
            if (moduleNode == null)
            {
                moduleNode = new XElement(module);
                root.Add(moduleNode);
            }

            var methodNode = moduleNode.Elements(method).SingleOrDefault();
            if (methodNode == null)
            {
                methodNode = new XElement(method);
                moduleNode.Add(methodNode);
            }

            var filterAttribute = methodNode.Attributes(filter).SingleOrDefault();
            if (filterAttribute == null)
            {
                filterAttribute = new XAttribute(filter, value);
                methodNode.Add(filterAttribute);
            }
            else
            {
                filterAttribute.Value = value;
            }

            return $"{xmlDocument.Declaration}\r\n{xmlDocument}";
        }

        /// <summary>
        /// Removes a filter in the supplied XML filters.
        /// </summary>
        /// <param name="module">The module containing the filter to remove.</param>
        /// <param name="method">The method containing the filter to remove.</param>
        /// <param name="filter">The filter to remove.</param>
        /// <param name="currentFiltersText">The XML filters.</param>
        /// <returns>
        /// The updated filter XML as a string.
        /// </returns>
        public string RemoveFilter(string module, string method, string filter, string currentFiltersText)
        {
            if (string.IsNullOrWhiteSpace(module) || string.IsNullOrWhiteSpace(method) ||
                string.IsNullOrWhiteSpace(filter))
            {
                throw new ArgumentException("Error removing Filter: Values must be provided for Module, Method and Filter");
            }

            if (string.IsNullOrWhiteSpace(currentFiltersText))
            {
                return string.Empty;
            }

            var xmlDocument = XDocument.Parse(currentFiltersText);

            if (xmlDocument.Declaration == null)
            {
                xmlDocument.Declaration = new XDeclaration("1.0", "UTF-8", null);
            }

            var moduleNode = xmlDocument.Elements("Filters").SingleOrDefault()?.Elements(module).SingleOrDefault();

            var methodNode = moduleNode?.Elements(method).SingleOrDefault();

            var filterAttribute = methodNode?.Attributes(filter).SingleOrDefault();

            if (filterAttribute != null)
            {
                filterAttribute.Remove();

                if (!methodNode.HasAttributes)
                {
                    methodNode.Remove();
                }

                if (!moduleNode.HasElements)
                {
                    moduleNode.Remove();
                }
            }

            return $"{xmlDocument.Declaration}\r\n{xmlDocument}";
        }
    }
}