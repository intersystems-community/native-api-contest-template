#!/bin/bash

echo "Building..."
pip3 install nativeAPI_wheel/irisnative-1.0.0-cp34-abi3-linux_x86_64.whl 

echo "Executing..."
python3 IRISNative.py 