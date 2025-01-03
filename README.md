# Unity AR App for iOS

Welcome to the Unity AR App! This project leverages Augmented Reality (AR) to provide an interactive experience by integrating digital content, such as 3D objects, sounds, and animations, into the real world.

## Features
- Explore and interact with 3D objects in AR.
- Rotate objects, play associated sounds, and switch between objects.
- Easily customizable with new 3D models, sounds, and image targets.

![App insights](https://github.com/user-attachments/assets/4dbdc04d-98d7-4c93-981c-d6f49be3e389)
![App insights](https://github.com/user-attachments/assets/94a7c7a6-4bfd-44ca-bc29-9d78b5644a50)
![Eagle AR-App](https://github.com/user-attachments/assets/7a1ae6ea-6a26-4fd4-93d7-c448fe72a229)


## Requirements

### Software
- Unity 2022.3.52f1
- Vuforia Engine (Unity Plugin)
- Xcode (for iOS builds)

### Hardware
- Mac computer (for iOS builds)
- iPhone (for testing)

### Assets
- 3D models (`.fbx`, `.obj`, `.glTF`)
- Audio files (`.mp3`, `.wav`)
- Background image (for image targets)

## Getting Started

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/arda-oeztuerk/ar-unity-tutorial-ios.git
   
Navigate to the project directory and open it in Unity.

2. **Import Assets**:
   - Drag and drop new 3D models, textures, or audio files into the Unity Assets folder.
   - Use organized folders for better asset management.

3. **Configure AR Content**:
   - Add imported 3D models as child objects to image targets.
   - Configure positions, scales, and interactions in the Unity Hierarchy and Inspector.

4. **Build the App**:
   - Select **File > Build Settings** in Unity.
   - Choose iOS as the platform and switch platforms if necessary.
   - Add required scenes and build the Xcode project.

5. **Deploy to iPhone**:
   - Open the exported Xcode project, configure signing profiles, and connect your iPhone.
   - Build and run the app on your device.

## Customization Guide

### Adding New 3D Objects
- Import 3D models into Unity and ensure textures/materials are properly assigned.
- Add them to the Hierarchy as child objects of the relevant image target.

### Adding New Sounds
- Import audio files into the Assets folder.
- Assign them to the corresponding objects in the `Multi Object Interaction` component.

### Creating New Image Targets
- Import background images and assign them as new image targets in the Vuforia configuration.

## Testing
- Ensure proper lighting and visibility for image targets.
- Test interactions (e.g., buttons, object manipulation) to verify correct functionality.

## License
This project is released under the [CC0 License](https://creativecommons.org/public-domain/cc0/). You are free to use, modify, and distribute this work without any restrictions.
