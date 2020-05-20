# native-api-contest-template
This is a template for for an InterSystems IRIS Native API Contest.  The Native API provides fast and easy access to globals and objectscript from your application.

Provided in this template is a docker file to get you started and sample programs in each supported language (Java, .Net, Node, and Python).  The sample program demonstrates basic usage of the native API.  

## Getting started documentation

InterSystems has a number of documents on the Native API, including code examples. The[Introduction to the Native API](https://docs.intersystems.com/irislatest/csp/docbook/DocBook.UI.Page.cls?KEY=BJAVNAT_intro) is a good place to start.

## Contest Overview

The Native API contest seeks to find novel uses of the Native API to solve problems that are difficult to solve with SQL.  Solve any sort of problem that you find interesting.  You may build any sort of application so long as the build and run instructions are clear in your readme file.

## Instructions

You should provide a repository where docker-compose can be used to build a container image that contains Intersystems IRIS and any setup you need for your application. 
You should include instructions for running your application within the docker image. 

Sample programs are contained in this repository to make it easier to get started.
* [Java](https://github.com/intersystems-community/native-api-contest-template/blob/master/src/java/README.md)
* [Python](https://github.com/intersystems-community/native-api-contest-template/blob/master/src/python/README.md)
* [.NET Core](https://github.com/intersystems-community/native-api-contest-template/blob/master/src/dotnet/README.md)
* [NodeJS](https://github.com/intersystems-community/native-api-contest-template/blob/master/src/nodejs/README.md)

Each of the included examples can be built and executed in the container by running `./run.sh` from their respective directories.


# Template Contest Submissions

## Inspiration
To make an easy template to start building apps using the IRIS native API

## What it does
Please take some time to explain what your application does, now it uses the IRIS native API, and what makes it awesome.

## Challenges I ran into
no challenges

## Accomplishments that I proud of
Easy template with self documented API spec installed with one ZPM command or docker-compose build

## What I learned
a lot!

## Built with
Using VSCode and ObjectScript plugin, IRIS Community Edition in Docker, ZPM, IRIS openapi API


## Installation with Docker

## Prerequisites
Make sure you have [git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git) and [Docker desktop](https://www.docker.com/products/docker-desktop) installed.


Clone/git pull the repo into any local directory e.g. like it is shown below:

```
$ git clone https://github.com/intersystems-community/native-api-contest-template
```

Open the terminal in this directory and run:

```
$ docker-compose up -d --build
```

## How to Work With it

Start a bash shell to the container and execute `run.sh`


## Troubleshooting Docker-Compose

If docker-compose fails, the two most common problems are:

1. Docker version mismatch.  The docker-compose specifies version 3.6. If you have a different version, you should be able to just change the version in `docker-compose.yml`
2. Port unavailable.  If you're already running a container on your machine, you might need to change the port number that is exported.

## How to start coding
This is a template, so you can use a template button on Github to create your own copy of this repository.
The repository is ready to code in VSCode with ObjectScript plugin.
Install [VSCode](https://code.visualstudio.com/) and [ObjectScript](https://marketplace.visualstudio.com/items?itemName=daimor.vscode-objectscript) plugin and open the folder in VSCode.
Once you start IRIS container VSCode connects to it and you can edit, compile and debug ObjectScript code.
Open /src/cls/PackageSample/ObjectScript.cls class and try to make changes - it will be compiled in running IRIS docker container.

Feel free to delete PackageSample folder and place your ObjectScript classes in a form
/src/cls/Package/Classname.cls

The script in Installer.cls will import everything you place under /src/cls into IRIS.

## Collaboration 
Any collaboration is very welcome! Fork and send Pull requests!
