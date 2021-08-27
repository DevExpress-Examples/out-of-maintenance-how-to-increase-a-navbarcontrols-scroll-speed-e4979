<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633383/13.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4979)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication44/Form1.cs)
* [Program.cs](./CS/WindowsFormsApplication44/Program.cs)
<!-- default file list end -->
# How to increase a NavBarControl's scroll speed


<p>Sometimes, when dragging a NavBarItem, a NavBarControl's scroll speed is very slow. This example demonstrates how to increase the current NavBarControl's scroll speed. </p><br />
<p>So, to achieve this goal, you can create a NavBarControl descendant and override its CreateViewInfo method and return a ExplorerBarNavBarViewInfo descendant. After that, override the ExplorerBarNavBarViewInfo.TopY property.</p>

<br/>


