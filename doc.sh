#!/bin/bash

source env.sh

#Create Data Model Documentation
puml-gen Md.Shared/src/Model Md.Shared/doc -dir -createAssociation
