#version 330 core

out vec4 FragColor;

//in vec3 ourColor;
in vec3 positionToColor;

void main()
{
   FragColor = vec4(positionToColor, 1.0);
};