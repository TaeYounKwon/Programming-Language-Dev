cmake_minimum_required(VERSION 3.16)
project(testing)

set(CMAKE_CXX_STANDARD 14)

add_executable( main.cpp evaluator.cpp evaluator.h)