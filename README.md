# iSAMS Batch API Example App

## Introduction

To aid development and understanding of how the Batch API works we have created a simple example application that shows how to build requests to Batch API endpoints and pass in filters. The application is written in C# and built using Visual Studio 2019.

## Pre-requisites

* Visual Studio 2019

## Description

The application is a Windows Forms application which can be used to create and send test requests to an iSAMS Batch API instance.

The intention of the application is to allow integrators to see how to write code to make such requests, with the key classes being:

* `Services.Implementations.RequestService` for creating the requests themselves.
* `Services.Implementations.FiltersXmlService` for building the XML filters.

Requests can be made for data from XML or Staff/Student Photos endpoints.

Please refer to the iSAMS Batch API documentation to see which filters can be applied to each Batch API method.