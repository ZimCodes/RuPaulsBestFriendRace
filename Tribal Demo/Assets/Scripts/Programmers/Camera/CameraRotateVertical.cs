﻿using UnityEngine;

public class CameraRotateVertical : CameraRotate
{
    public float VerticalRotation;
    public CameraRotateVertical(GameObject _target, float _movecamerapercent = .347f, string _nameoflayertoignore = "Player") : base(_target,_movecamerapercent,_nameoflayertoignore)
    {
        
    }
    public override void Start(Transform cameraTransform)
    {
        AxisToRotateAbout = Vector3.right;
        
    }
    public override void LateUpdate(Transform cameraTransform)
    {
        RotateObjectFormula(cameraTransform);
    }
    private void RotateObjectFormula(Transform cameraTransform)
    {
        Quaternion camTurnAngle = Quaternion.AngleAxis(VerticalRotation * CameraRotationSpeed, AxisToRotateAbout);
        cameraTransform.Rotate(camTurnAngle.eulerAngles);

    }
}
