# MSD_COMP826_FireFighterAssistanceHelmet

To run project (After downloading it as a zip):
- Unzip the project
- Install Unity Hub and create an account
- In 'Projects' press the 'Add' button where a drop down will appear
- In the drop down select 'Add project from disk'
- Select the unzipped project
- It will appear as a project, where you can select it and run it


Implementing Object recognition into Unity:

AR Object Detection in Unity + Lightship (Tutorial) Link:
https://www.youtube.com/watch?v=aZ9qAbeRwQ8

This program uses the AR Object Detection in Unity + Lightship Tutorial with some slight changes such as the
spawn objects not being added and the bounding box only appearing when a person comes into frame 

You may need to add the Lightship items into the Package manager, below are the steps to add it also you will need to register to Lightship.dev 

- Register to Lightship.dev and create a project, name it anything and the API code will be used later
- When running unity in Window -> Package Manager press the '+' at the top left and select "Add package from git URL".
- Paste the 2 URLs below one by one
    - https://github.com/niantic-lightship/ardk-upm.git 
    - https://github.com/niantic-lightship/sharedar-upm.git
- Exit Package manager and at the top select Lightship -> Settings then head to XR Plug-in Management
- In the Plug-in Providers select Niantic Lightship SDK for Unity Editor
- In the Setting tab go to Niantic Lightship SDK, from the project in your lightship add in the API key in Credentials
- In the Setting tab go to Project Validation and check for any issues

Note:
The image recognition using a video and not a camera input for testing
You will need to go to Lightship -> Settings then head to Niantic Lightship SDK
scrolling to the bottom till you see Playback, enable it and browse for Dataset Path
The testing videos should be contained in the Assests -> Testing, add a folder in there

Afterwards with everything on unity run the program. 