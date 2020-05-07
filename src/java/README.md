﻿# Example Native API Application

Taken straight from https://docs.intersystems.com/irislatest/csp/docbook/Doc.View.cls?KEY=AFL_dbnative

## How to build this example

On Windows
```
javac -classpath "C:\InterSystems\IRIS\dev\java\lib\JDK18\intersystems-gateway-3.1.0.jar;C:\InterSystems\IRIS\dev\java\lib\JDK18\intersystems-jdbc-3.1.0.jar" -d bin src\IRISNative\IRISNative.java
```

On UNIX


```
cd src/java

javac -classpath /usr/irissys/dev/java/lib/JDK18/intersystems-jdbc-3.1.0.jar -d bin src/IRISNative/IRISNative.java
```


## How to build and run this example in the container

```
cd bin
java IRISNative
```

