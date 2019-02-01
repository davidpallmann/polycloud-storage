# polycloud-storage
PolyCloud-API library for cloud storage.

![PolyCloud-API-logo](https://s3.amazonaws.com/david-pallmann-public/PolyCloud-small.png)

__PolyCloud-API__ is an API initiative that provides unified libraries for accessing AWS, Azure, and Google cloud platforms and performing common operations.

__PolyCloud-Storage__ is the PolyCloud-API library for cloud storage; that is, files and folders. This library's initial goals are modest: to provide an easy way to perform common storage operations that exist on all three cloud platforms.

We never want your data to be lost or your credentials to be compromised. Please be aware that this is a new (alpha) library and as such you should not use it for Production data unless you have become comfortable working with it. Please exercise caution.

# .NET Framework Edition

The .NET Framework Edition uses .NET 4.6.1.

## Dependencies

The .NET Framework edition of PolyCloud-Storage uses these nuget libraries:

* Amazon Web Services: AWSSDK.S3 and dependent libraries
* Microsoft Azure: Microsoft.Azure.Storage.Blob
* Google Cloud Platform: Google.Cloud.Storage.v1 and dependent libraries

## Documentation

[Read the API documentation](https://github.com/davidpallmann/polycloud-storage/wiki/API-Documentation---.NET-Framework)

## Building

To build PolyCloud.Storage for .NET Framework you need Visual Studio 2017 Community or higher.

The source code includes these projects:
* PolyCloud.Storage: the .NET Framework library
* PolyCloud.Storage.Tests: unit tests that can be run in Visual Studio Test Explorer (before running, edit to supply your storage account credentials)
