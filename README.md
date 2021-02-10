## Game Mechanics Toolkit (GMT)
A collection of assets to support the creation of games and XR experiences using Unity.

## How to use

Import the package using the [UPM Git support.](https://docs.unity3d.com/Manual/upm-ui-giturl.html)
Something like:
```
"com.adjuvant.gmt": "https://github.com/Adjuvant/game-mechanics-toolkit.git#upm"
```
### __Project Structure__



### __Commit and Semantic Release Notes__
Every time you commit to `master`, this YML file is used to release your UPM package and automatically use a separate upm branch for releases as well as autogenerate tag for release. If you see the upm branch commits, you'll notice that your project directory is the root instead of the Unity project directory. Github Actions is used to automate this bit.

When using `git commit`, follow the [Angular Standard](https://github.com/angular/angular/blob/master/CONTRIBUTING.md#commit)

Semantic releases is used to automate changelog updates as well as incrementing the version field inside `package.json` (the UPM Manifest).

### __Publishing to package registries__
Use `npm publish` inside `Packages/GMT` or check out [OpenUPM](https://openupm.com/docs/#how-it-works)  

#### Further Resources
[Favo Yang's Medium Articles](https://medium.com/@favoyang)  
[OpenUPM Docs](https://openupm.com/docs/)  
[Having a Docker Container As Your Private NPM Registry — The Easy Way by Sibeesh Venu](https://medium.com/better-programming/having-a-docker-container-as-your-private-npm-registry-the-easy-way-68159fa94cc4)  

## Contact
[@github](https://www.github.com/Adjuvant)  
[@www](http://www.layeraudio.com)
