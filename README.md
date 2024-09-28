# Unity Selection Carousel

This is a script i've made for Unity3D, which provides an algorithm for managing a list of targets, by creating an item carousel for it.
With the item carousel you gain the ability to control items (for example a 4 target camera system, where with a press of the arrows, you swap to the next/previous camera).

### Example:
![unity-carousel](https://github.com/user-attachments/assets/a72712dd-e13e-4a4c-8eef-077bd1b3e2e3)

This can be used in multiple projects such as: A character selection screen, an item selection/viewer, auto camera swap etc.

## How to use:
1. Upload the script to your project.
2. Create a group with objects and a parent.
3. Inherit the script to your class.
4. Inititalise the group of objects by calling the function Init_SelecTargets(GameObject targetParent).
5. Adjust your code, so whenever you want to move to the next item in the carousel, by calling the NextTarget() or PrevTarget() functions.


## Class-Diagram:
![untiy-target-carousel](https://github.com/user-attachments/assets/0ed23c6f-6cb6-4307-9faf-394b3167c558)
