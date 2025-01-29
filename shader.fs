#version 330 core

out vec4 FragColor;

in vec3 ourColor;
in vec2 texel;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
   FragColor = mix(texture(texture1, texel), texture(texture2, texel), 0.2);
};