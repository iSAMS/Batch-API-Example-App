namespace iSAMS.BatchAPI.Demo.Core.Services.Interfaces
{
    /// <summary>
    /// Service to process XML filters for an API request.
    /// </summary>
    public interface IFiltersXmlService
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
        string AddUpdateFilter(string module, string method, string filter, string value, string currentFiltersText);
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
        string RemoveFilter(string module, string method, string filter, string currentFiltersText);
    }
}