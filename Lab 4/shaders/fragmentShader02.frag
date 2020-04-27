uniform float time;
uniform vec2 resolution;
void main()	{
    float x = mod(time + gl_FragCoord.x, 42.);
    float y = mod(time + gl_FragCoord.y, 42.);
    gl_FragColor = vec4(vec3(min(x, y)), 1.);
}