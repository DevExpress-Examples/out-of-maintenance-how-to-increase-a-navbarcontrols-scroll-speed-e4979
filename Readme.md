# How to increase a NavBarControl's scroll speed


<p>Sometimes, when dragging a NavBarItem, a NavBarControl's scroll speed is very slow. This example demonstrates how to increase the current NavBarControl's scroll speed. </p><br />
<p>So, to achieve this goal, you can create a NavBarControl descendant and override its CreateViewInfo method and return a ExplorerBarNavBarViewInfo descendant. After that, override the ExplorerBarNavBarViewInfo.TopY property.</p>

<br/>


