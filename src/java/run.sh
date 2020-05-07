#!/bin/bash

echo "Building..."
javac -classpath /usr/irissys/dev/java/lib/JDK18/intersystems-jdbc-3.1.0.jar -d bin src/IRISNative/IRISNative.java

echo "Executing..."
cd bin
java IRISNative
