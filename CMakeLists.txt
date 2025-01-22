cmake_minimum_required(VERSION 3.30)
project(OpenGLTest)

set(CMAKE_CXX_STANDARD 17)

find_package(glfw3 REQUIRED)

add_executable(OpenGLTest main.cpp)

target_link_libraries(OpenGLTest glfw)