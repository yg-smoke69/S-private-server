using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BC0")]
public class RCC_Settings
{
	[Token(Token = "0x2003BC1")]
	public enum BehaviorType
	{
		[Token(Token = "0x401977E")]
		Simulator,
		[Token(Token = "0x401977F")]
		Racing,
		[Token(Token = "0x4019780")]
		SemiArcade,
		[Token(Token = "0x4019781")]
		Drift,
		[Token(Token = "0x4019782")]
		Fun,
		[Token(Token = "0x4019783")]
		Custom
	}

	[Token(Token = "0x2003BC2")]
	public enum ControllerType
	{
		[Token(Token = "0x4019785")]
		Keyboard,
		[Token(Token = "0x4019786")]
		Mobile,
		[Token(Token = "0x4019787")]
		Custom
	}

	[Token(Token = "0x2003BC3")]
	public enum Units
	{
		[Token(Token = "0x4019789")]
		KMH,
		[Token(Token = "0x401978A")]
		MPH
	}

	[Token(Token = "0x401974F")]
	[FieldOffset(Offset = "0x0")]
	public static RCC_Settings instance;

	[Token(Token = "0x4019750")]
	[FieldOffset(Offset = "0x8")]
	public bool overrideFixedTimeStep;

	[Token(Token = "0x4019751")]
	[FieldOffset(Offset = "0xC")]
	public float fixedTimeStep;

	[Token(Token = "0x4019752")]
	[FieldOffset(Offset = "0x10")]
	public float maxAngularVelocity;

	[Token(Token = "0x4019753")]
	[FieldOffset(Offset = "0x14")]
	public BehaviorType behaviorType;

	[Token(Token = "0x4019754")]
	[FieldOffset(Offset = "0x18")]
	public bool useFixedWheelColliders;

	[Token(Token = "0x4019755")]
	[FieldOffset(Offset = "0x1C")]
	public ControllerType controllerType;

	[Token(Token = "0x4019756")]
	[FieldOffset(Offset = "0x20")]
	public string verticalInput;

	[Token(Token = "0x4019757")]
	[FieldOffset(Offset = "0x24")]
	public string horizontalInput;

	[Token(Token = "0x4019758")]
	[FieldOffset(Offset = "0x28")]
	public KeyCode handbrakeKB;

	[Token(Token = "0x4019759")]
	[FieldOffset(Offset = "0x2C")]
	public KeyCode changeCameraKB;

	[Token(Token = "0x401975A")]
	[FieldOffset(Offset = "0x30")]
	public KeyCode enterExitVehicleKB;

	[Token(Token = "0x401975B")]
	[FieldOffset(Offset = "0x34")]
	public bool useAutomaticGear;

	[Token(Token = "0x401975C")]
	[FieldOffset(Offset = "0x35")]
	public bool keepEnginesAlive;

	[Token(Token = "0x401975D")]
	[FieldOffset(Offset = "0x36")]
	public bool autoReverse;

	[Token(Token = "0x401975E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject contactParticles;

	[Token(Token = "0x401975F")]
	[FieldOffset(Offset = "0x3C")]
	public Units units;

	[Token(Token = "0x4019760")]
	[FieldOffset(Offset = "0x40")]
	public bool useTelemetry;

	[Token(Token = "0x4019761")]
	[FieldOffset(Offset = "0x41")]
	public bool useAccelerometerForSteering;

	[Token(Token = "0x4019762")]
	[FieldOffset(Offset = "0x42")]
	public bool useSteeringWheelForSteering;

	[Token(Token = "0x4019763")]
	[FieldOffset(Offset = "0x44")]
	public float UIButtonSensitivity;

	[Token(Token = "0x4019764")]
	[FieldOffset(Offset = "0x48")]
	public float UIButtonGravity;

	[Token(Token = "0x4019765")]
	[FieldOffset(Offset = "0x4C")]
	public float gyroSensitivity;

	[Token(Token = "0x4019766")]
	[FieldOffset(Offset = "0x50")]
	public bool useLightsAsVertexLights;

	[Token(Token = "0x4019767")]
	[FieldOffset(Offset = "0x51")]
	public bool useLightProjectorForLightingEffect;

	[Token(Token = "0x4019768")]
	[FieldOffset(Offset = "0x54")]
	public string RCCLayer;

	[Token(Token = "0x4019769")]
	[FieldOffset(Offset = "0x58")]
	public string RCCTag;

	[Token(Token = "0x401976A")]
	[FieldOffset(Offset = "0x5C")]
	public bool tagAllChildrenGameobjects;

	[Token(Token = "0x401976B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject chassisJoint;

	[Token(Token = "0x401976C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject exhaustGas;

	[Token(Token = "0x401976D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject projector;

	[Token(Token = "0x401976E")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask projectorIgnoreLayer;

	[Token(Token = "0x401976F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject headLights;

	[Token(Token = "0x4019770")]
	[FieldOffset(Offset = "0x74")]
	public GameObject brakeLights;

	[Token(Token = "0x4019771")]
	[FieldOffset(Offset = "0x78")]
	public GameObject reverseLights;

	[Token(Token = "0x4019772")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject indicatorLights;

	[Token(Token = "0x4019773")]
	[FieldOffset(Offset = "0x80")]
	public GameObject mirrors;

	[Token(Token = "0x4019774")]
	[FieldOffset(Offset = "0x84")]
	public bool dontUseAnyParticleEffects;

	[Token(Token = "0x4019775")]
	[FieldOffset(Offset = "0x85")]
	public bool dontUseChassisJoint;

	[Token(Token = "0x4019776")]
	[FieldOffset(Offset = "0x86")]
	public bool dontUseSkidmarks;

	[Token(Token = "0x4019777")]
	[FieldOffset(Offset = "0x87")]
	public bool foldGeneralSettings;

	[Token(Token = "0x4019778")]
	[FieldOffset(Offset = "0x88")]
	public bool foldControllerSettings;

	[Token(Token = "0x4019779")]
	[FieldOffset(Offset = "0x89")]
	public bool foldUISettings;

	[Token(Token = "0x401977A")]
	[FieldOffset(Offset = "0x8A")]
	public bool foldWheelPhysics;

	[Token(Token = "0x401977B")]
	[FieldOffset(Offset = "0x8B")]
	public bool foldSFX;

	[Token(Token = "0x401977C")]
	[FieldOffset(Offset = "0x8C")]
	public bool foldOptimization;

	[Token(Token = "0x170018DA")]
	public static RCC_Settings Instance
	{
		[Token(Token = "0x6017D82")]
		[Address(RVA = "0x1E345E8", Offset = "0x1E345E8", VA = "0x1E345E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017D81")]
	[Address(RVA = "0x1E3C6A8", Offset = "0x1E3C6A8", VA = "0x1E3C6A8")]
	public RCC_Settings()
	{
	}
}
