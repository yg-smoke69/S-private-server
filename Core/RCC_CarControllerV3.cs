using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BBC")]
public class RCC_CarControllerV3 : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2003BBD")]
	public enum WheelType
	{
		[Token(Token = "0x4019741")]
		FWD,
		[Token(Token = "0x4019742")]
		RWD,
		[Token(Token = "0x4019743")]
		AWD,
		[Token(Token = "0x4019744")]
		BIASED
	}

	[Token(Token = "0x2003BBE")]
	public enum IndicatorsOn
	{
		[Token(Token = "0x4019746")]
		Off,
		[Token(Token = "0x4019747")]
		Right,
		[Token(Token = "0x4019748")]
		Left,
		[Token(Token = "0x4019749")]
		All
	}

	[Token(Token = "0x2003BBF")]
	private sealed class _003CChangingGear_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401974A")]
		[FieldOffset(Offset = "0x8")]
		internal int gear;

		[Token(Token = "0x401974B")]
		[FieldOffset(Offset = "0xC")]
		internal RCC_CarControllerV3 _0024this;

		[Token(Token = "0x401974C")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x401974D")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x401974E")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170018D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017D7D")]
			[Address(RVA = "0x1E3C5FC", Offset = "0x1E3C5FC", VA = "0x1E3C5FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170018D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017D7E")]
			[Address(RVA = "0x1E3C604", Offset = "0x1E3C604", VA = "0x1E3C604", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017D7B")]
		[Address(RVA = "0x1E3ABAC", Offset = "0x1E3ABAC", VA = "0x1E3ABAC")]
		public _003CChangingGear_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6017D7C")]
		[Address(RVA = "0x1E3C390", Offset = "0x1E3C390", VA = "0x1E3C390", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017D7F")]
		[Address(RVA = "0x1E3C60C", Offset = "0x1E3C60C", VA = "0x1E3C60C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017D80")]
		[Address(RVA = "0x1E3C620", Offset = "0x1E3C620", VA = "0x1E3C620", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40196C6")]
	[FieldOffset(Offset = "0xC")]
	protected Rigidbody rigid;

	[Token(Token = "0x40196C7")]
	[FieldOffset(Offset = "0x10")]
	internal bool sleepingRigid;

	[Token(Token = "0x40196C8")]
	[FieldOffset(Offset = "0x11")]
	public bool AIController;

	[Token(Token = "0x40196C9")]
	[FieldOffset(Offset = "0x14")]
	public RCC_WheelCollider FrontLeftWheelCollider;

	[Token(Token = "0x40196CA")]
	[FieldOffset(Offset = "0x18")]
	public Action ChangeGearDele;

	[Token(Token = "0x40196CB")]
	[FieldOffset(Offset = "0x1C")]
	public RCC_WheelCollider FrontRightWheelCollider;

	[Token(Token = "0x40196CC")]
	[FieldOffset(Offset = "0x20")]
	public RCC_WheelCollider RearLeftWheelCollider;

	[Token(Token = "0x40196CD")]
	[FieldOffset(Offset = "0x24")]
	public RCC_WheelCollider RearRightWheelCollider;

	[Token(Token = "0x40196CE")]
	[FieldOffset(Offset = "0x28")]
	internal RCC_WheelCollider[] allWheelColliders;

	[Token(Token = "0x40196CF")]
	[FieldOffset(Offset = "0x2C")]
	public Transform[] ExtraRearWheelsTransform;

	[Token(Token = "0x40196D0")]
	[FieldOffset(Offset = "0x30")]
	public RCC_WheelCollider[] ExtraRearWheelsCollider;

	[Token(Token = "0x40196D1")]
	[FieldOffset(Offset = "0x34")]
	public bool applyEngineTorqueToExtraRearWheelColliders;

	[Token(Token = "0x40196D2")]
	[FieldOffset(Offset = "0x38")]
	public Transform SteeringWheel;

	[Token(Token = "0x40196D3")]
	[FieldOffset(Offset = "0x3C")]
	public WheelType WheelTypeChoise;

	[Token(Token = "0x40196D4")]
	[FieldOffset(Offset = "0x40")]
	public float biasedWheelTorque;

	[Token(Token = "0x40196D5")]
	[FieldOffset(Offset = "0x44")]
	public Transform COM;

	[Token(Token = "0x40196D6")]
	[FieldOffset(Offset = "0x48")]
	public Transform SkinContainer;

	[Token(Token = "0x40196D7")]
	[FieldOffset(Offset = "0x4C")]
	public Transform SteeringWheelContainer;

	[Token(Token = "0x40196D8")]
	[FieldOffset(Offset = "0x50")]
	private List<RCC_WheelCollider> m_WheelColliders;

	[Token(Token = "0x40196D9")]
	[FieldOffset(Offset = "0x54")]
	public bool canControl;

	[Token(Token = "0x40196DA")]
	[FieldOffset(Offset = "0x55")]
	public bool engineRunning;

	[Token(Token = "0x40196DB")]
	[FieldOffset(Offset = "0x56")]
	public bool semiAutomaticGear;

	[Token(Token = "0x40196DC")]
	[FieldOffset(Offset = "0x57")]
	private bool canGoReverseNow;

	[Token(Token = "0x40196DD")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve[] engineTorqueCurve;

	[Token(Token = "0x40196DE")]
	[FieldOffset(Offset = "0x5C")]
	public float[] gearSpeed;

	[Token(Token = "0x40196DF")]
	[FieldOffset(Offset = "0x60")]
	public float engineTorque;

	[Token(Token = "0x40196E0")]
	[FieldOffset(Offset = "0x64")]
	public float brakeTorque;

	[Token(Token = "0x40196E1")]
	[FieldOffset(Offset = "0x68")]
	public float maxEngineRPM;

	[Token(Token = "0x40196E2")]
	[FieldOffset(Offset = "0x6C")]
	public float minEngineRPM;

	[Token(Token = "0x40196E3")]
	[FieldOffset(Offset = "0x70")]
	public float engineInertia;

	[Token(Token = "0x40196E4")]
	[FieldOffset(Offset = "0x74")]
	public bool useRevLimiter;

	[Token(Token = "0x40196E5")]
	[FieldOffset(Offset = "0x75")]
	public bool useExhaustFlame;

	[Token(Token = "0x40196E6")]
	[FieldOffset(Offset = "0x78")]
	private float steerAngle;

	[Token(Token = "0x40196E7")]
	[FieldOffset(Offset = "0x7C")]
	public int SpeedSteerAudio;

	[Token(Token = "0x40196E8")]
	[FieldOffset(Offset = "0x80")]
	public string SpeedSteerAudioResID;

	[Token(Token = "0x40196E9")]
	[FieldOffset(Offset = "0x84")]
	public float highspeedsteerAngle;

	[Token(Token = "0x40196EA")]
	[FieldOffset(Offset = "0x88")]
	public float highspeedsteerAngleAtspeed;

	[Token(Token = "0x40196EB")]
	[FieldOffset(Offset = "0x8C")]
	public float antiRollFrontHorizontal;

	[Token(Token = "0x40196EC")]
	[FieldOffset(Offset = "0x90")]
	public float antiRollRearHorizontal;

	[Token(Token = "0x40196ED")]
	[FieldOffset(Offset = "0x94")]
	public float antiRollVertical;

	[Token(Token = "0x40196EE")]
	[FieldOffset(Offset = "0x98")]
	public float downForce;

	[Token(Token = "0x40196EF")]
	[FieldOffset(Offset = "0x9C")]
	private float speed;

	[Token(Token = "0x40196F0")]
	[FieldOffset(Offset = "0xA0")]
	public Transform RootTrans;

	[Token(Token = "0x40196F1")]
	[FieldOffset(Offset = "0xA4")]
	public float defMaxSpeed;

	[Token(Token = "0x40196F2")]
	[FieldOffset(Offset = "0xA8")]
	public float maxspeed;

	[Token(Token = "0x40196F3")]
	[FieldOffset(Offset = "0xAC")]
	private float mSpeedScale;

	[Token(Token = "0x40196F4")]
	[FieldOffset(Offset = "0xB0")]
	protected float mDriverSpeedScale;

	[Token(Token = "0x40196F5")]
	[FieldOffset(Offset = "0xB4")]
	private float resetTime;

	[Token(Token = "0x40196F6")]
	[FieldOffset(Offset = "0xB8")]
	private float orgSteerAngle;

	[Token(Token = "0x40196F7")]
	[FieldOffset(Offset = "0xBC")]
	private float fuelInput;

	[Token(Token = "0x40196F8")]
	[FieldOffset(Offset = "0xC0")]
	public int currentGear;

	[Token(Token = "0x40196F9")]
	[FieldOffset(Offset = "0xC4")]
	public int totalGears;

	[Token(Token = "0x40196FA")]
	[FieldOffset(Offset = "0xC8")]
	public float gearShiftingDelay;

	[Token(Token = "0x40196FB")]
	[FieldOffset(Offset = "0xCC")]
	public bool changingGear;

	[Token(Token = "0x40196FC")]
	[FieldOffset(Offset = "0xD0")]
	private int direction;

	[Token(Token = "0x40196FD")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_ReachSpeedAndTurnMax;

	[Token(Token = "0x40196FE")]
	[FieldOffset(Offset = "0xD5")]
	public bool autoGenerateGearCurves;

	[Token(Token = "0x40196FF")]
	[FieldOffset(Offset = "0xD6")]
	public bool autoGenerateTargetSpeedsForChangingGear;

	[Token(Token = "0x4019700")]
	[FieldOffset(Offset = "0xD7")]
	private bool mModelVisible;

	[Token(Token = "0x4019701")]
	[FieldOffset(Offset = "0xD8")]
	private float gasInput;

	[Token(Token = "0x4019702")]
	[FieldOffset(Offset = "0xDC")]
	private float brakeInput;

	[Token(Token = "0x4019703")]
	[FieldOffset(Offset = "0xE0")]
	private float steerInput;

	[Token(Token = "0x4019704")]
	[FieldOffset(Offset = "0xE4")]
	public float clutchInput;

	[Token(Token = "0x4019705")]
	[FieldOffset(Offset = "0xE8")]
	public float handbrakeInput;

	[Token(Token = "0x4019706")]
	[FieldOffset(Offset = "0xEC")]
	public float boostInput;

	[Token(Token = "0x4019707")]
	[FieldOffset(Offset = "0xF0")]
	public bool cutGas;

	[Token(Token = "0x4019708")]
	[FieldOffset(Offset = "0xF4")]
	public float idleInput;

	[Token(Token = "0x4019709")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_IsInWater;

	[Token(Token = "0x401970A")]
	[FieldOffset(Offset = "0xFC")]
	internal float engineRPM;

	[Token(Token = "0x401970B")]
	[FieldOffset(Offset = "0x100")]
	internal float rawEngineRPM;

	[Token(Token = "0x401970C")]
	[FieldOffset(Offset = "0x104")]
	public IndicatorsOn indicatorsOn;

	[Token(Token = "0x401970D")]
	[FieldOffset(Offset = "0x108")]
	public float indicatorTimer;

	[Token(Token = "0x401970E")]
	[FieldOffset(Offset = "0x10C")]
	private float oldRotation;

	[Token(Token = "0x401970F")]
	[FieldOffset(Offset = "0x110")]
	public Transform velocityDirection;

	[Token(Token = "0x4019710")]
	[FieldOffset(Offset = "0x114")]
	public Transform steeringDirection;

	[Token(Token = "0x4019711")]
	[FieldOffset(Offset = "0x118")]
	public float velocityAngle;

	[Token(Token = "0x4019712")]
	[FieldOffset(Offset = "0x11C")]
	private float angle;

	[Token(Token = "0x4019713")]
	[FieldOffset(Offset = "0x120")]
	private float angularVelo;

	[Token(Token = "0x4019714")]
	[FieldOffset(Offset = "0x124")]
	public bool ABS;

	[Token(Token = "0x4019715")]
	[FieldOffset(Offset = "0x125")]
	public bool TCS;

	[Token(Token = "0x4019716")]
	[FieldOffset(Offset = "0x126")]
	public bool ESP;

	[Token(Token = "0x4019717")]
	[FieldOffset(Offset = "0x127")]
	public bool steeringHelper;

	[Token(Token = "0x4019718")]
	[FieldOffset(Offset = "0x128")]
	public bool tractionHelper;

	[Token(Token = "0x4019719")]
	[FieldOffset(Offset = "0x12C")]
	public float ABSThreshold;

	[Token(Token = "0x401971A")]
	[FieldOffset(Offset = "0x130")]
	public float TCSThreshold;

	[Token(Token = "0x401971B")]
	[FieldOffset(Offset = "0x134")]
	public float TCSStrength;

	[Token(Token = "0x401971C")]
	[FieldOffset(Offset = "0x138")]
	public float ESPThreshold;

	[Token(Token = "0x401971D")]
	[FieldOffset(Offset = "0x13C")]
	public float ESPStrength;

	[Token(Token = "0x401971E")]
	[FieldOffset(Offset = "0x140")]
	public float steerHelperLinearVelStrength;

	[Token(Token = "0x401971F")]
	[FieldOffset(Offset = "0x144")]
	public float steerHelperAngularVelStrength;

	[Token(Token = "0x4019720")]
	[FieldOffset(Offset = "0x148")]
	public float tractionHelperStrength;

	[Token(Token = "0x4019721")]
	[FieldOffset(Offset = "0x14C")]
	public bool ABSAct;

	[Token(Token = "0x4019722")]
	[FieldOffset(Offset = "0x14D")]
	public bool TCSAct;

	[Token(Token = "0x4019723")]
	[FieldOffset(Offset = "0x14E")]
	public bool ESPAct;

	[Token(Token = "0x4019724")]
	[FieldOffset(Offset = "0x14F")]
	public bool overSteering;

	[Token(Token = "0x4019725")]
	[FieldOffset(Offset = "0x150")]
	public bool underSteering;

	[Token(Token = "0x4019726")]
	[FieldOffset(Offset = "0x154")]
	internal float driftAngle;

	[Token(Token = "0x4019727")]
	[FieldOffset(Offset = "0x158")]
	internal bool driftingNow;

	[Token(Token = "0x4019728")]
	[FieldOffset(Offset = "0x159")]
	private bool applyCounterSteering;

	[Token(Token = "0x4019729")]
	[FieldOffset(Offset = "0x15C")]
	public float frontCamber;

	[Token(Token = "0x401972A")]
	[FieldOffset(Offset = "0x160")]
	public float rearCamber;

	[Token(Token = "0x401972B")]
	[FieldOffset(Offset = "0x164")]
	public float frontSlip;

	[Token(Token = "0x401972C")]
	[FieldOffset(Offset = "0x168")]
	public float rearSlip;

	[Token(Token = "0x401972D")]
	[FieldOffset(Offset = "0x16C")]
	public float turboBoost;

	[Token(Token = "0x401972E")]
	[FieldOffset(Offset = "0x170")]
	public float NoS;

	[Token(Token = "0x401972F")]
	[FieldOffset(Offset = "0x174")]
	public bool useNOS;

	[Token(Token = "0x4019730")]
	[FieldOffset(Offset = "0x175")]
	public bool useTurbo;

	[Token(Token = "0x4019731")]
	[FieldOffset(Offset = "0x178")]
	private RCC_Camera carCamera;

	[Token(Token = "0x4019732")]
	[FieldOffset(Offset = "0x17C")]
	private float m_GearFactor;

	[Token(Token = "0x4019733")]
	[FieldOffset(Offset = "0x180")]
	public float IdleBrakeInput;

	[Token(Token = "0x4019734")]
	[FieldOffset(Offset = "0x184")]
	public float ClimbForwardYCheck;

	[Token(Token = "0x4019735")]
	[FieldOffset(Offset = "0x188")]
	public float ClimbSlipCheck;

	[Token(Token = "0x4019736")]
	[FieldOffset(Offset = "0x18C")]
	public float ClimbAdditionalTorque;

	[Token(Token = "0x4019737")]
	[FieldOffset(Offset = "0x190")]
	private bool m_isBoosting;

	[Token(Token = "0x4019738")]
	[FieldOffset(Offset = "0x194")]
	private float m_maxSpeedBackup;

	[Token(Token = "0x4019739")]
	[FieldOffset(Offset = "0x198")]
	private float m_engineTorqueBackup;

	[Token(Token = "0x401973A")]
	[FieldOffset(Offset = "0x19C")]
	private float m_highSpeedSteerAngleBackup;

	[Token(Token = "0x401973B")]
	[FieldOffset(Offset = "0x1A0")]
	private TssSdtFloat mHighSpeedSteerAngleRate;

	[Token(Token = "0x401973C")]
	[FieldOffset(Offset = "0x1A4")]
	private TssSdtFloat mEngineTorqueRate;

	[Token(Token = "0x401973D")]
	[FieldOffset(Offset = "0x1A8")]
	private TssSdtFloat mBrakeTorqueRate;

	[Token(Token = "0x401973E")]
	[FieldOffset(Offset = "0x1AC")]
	public Vector3 mobileDirction;

	[Token(Token = "0x401973F")]
	[FieldOffset(Offset = "0x1B8")]
	protected float m_LockSpeed;

	[Token(Token = "0x170018C4")]
	private RCC_Settings RCCSettings
	{
		[Token(Token = "0x6017D33")]
		[Address(RVA = "0x1E345E4", Offset = "0x1E345E4", VA = "0x1E345E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C5")]
	public Transform VehicleCOM
	{
		[Token(Token = "0x6017D34")]
		[Address(RVA = "0x1E34684", Offset = "0x1E34684", VA = "0x1E34684", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C6")]
	public List<RCC_WheelCollider> WheelColliders
	{
		[Token(Token = "0x6017D35")]
		[Address(RVA = "0x1E3468C", Offset = "0x1E3468C", VA = "0x1E3468C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018C7")]
	public bool autoReverse
	{
		[Token(Token = "0x6017D36")]
		[Address(RVA = "0x1E34804", Offset = "0x1E34804", VA = "0x1E34804")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018C8")]
	public bool automaticGear
	{
		[Token(Token = "0x6017D37")]
		[Address(RVA = "0x1E3482C", Offset = "0x1E3482C", VA = "0x1E3482C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018C9")]
	public float SteerAngle
	{
		[Token(Token = "0x6017D38")]
		[Address(RVA = "0x1E34854", Offset = "0x1E34854", VA = "0x1E34854", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018CA")]
	public float Velocity
	{
		[Token(Token = "0x6017D39")]
		[Address(RVA = "0x1E3485C", Offset = "0x1E3485C", VA = "0x1E3485C", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018CB")]
	public int Direction
	{
		[Token(Token = "0x6017D3B")]
		[Address(RVA = "0x1E34880", Offset = "0x1E34880", VA = "0x1E34880", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018CC")]
	public bool ReachSpeedAndTurnMax
	{
		[Token(Token = "0x6017D3C")]
		[Address(RVA = "0x1E34888", Offset = "0x1E34888", VA = "0x1E34888", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018CD")]
	public virtual bool IsGrounded
	{
		[Token(Token = "0x6017D3D")]
		[Address(RVA = "0x1E34890", Offset = "0x1E34890", VA = "0x1E34890", Slot = "44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018CE")]
	public bool ModelVisible
	{
		[Token(Token = "0x6017D3F")]
		[Address(RVA = "0x1E34AA0", Offset = "0x1E34AA0", VA = "0x1E34AA0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017D3E")]
		[Address(RVA = "0x1E34A98", Offset = "0x1E34A98", VA = "0x1E34A98", Slot = "4")]
		set
		{
		}
	}

	[Token(Token = "0x170018CF")]
	public float GasInput
	{
		[Token(Token = "0x6017D40")]
		[Address(RVA = "0x1E34AA8", Offset = "0x1E34AA8", VA = "0x1E34AA8", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018D0")]
	public float BrakeInput
	{
		[Token(Token = "0x6017D41")]
		[Address(RVA = "0x1E34AB0", Offset = "0x1E34AB0", VA = "0x1E34AB0", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018D1")]
	public float SteerInput
	{
		[Token(Token = "0x6017D42")]
		[Address(RVA = "0x1E34AB8", Offset = "0x1E34AB8", VA = "0x1E34AB8", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018D2")]
	internal float _gasInput
	{
		[Token(Token = "0x6017D43")]
		[Address(RVA = "0x1E34AC0", Offset = "0x1E34AC0", VA = "0x1E34AC0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017D44")]
		[Address(RVA = "0x1E34BE0", Offset = "0x1E34BE0", VA = "0x1E34BE0")]
		set
		{
		}
	}

	[Token(Token = "0x170018D3")]
	internal float _brakeInput
	{
		[Token(Token = "0x6017D45")]
		[Address(RVA = "0x1E34BE8", Offset = "0x1E34BE8", VA = "0x1E34BE8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017D46")]
		[Address(RVA = "0x1E34CD4", Offset = "0x1E34CD4", VA = "0x1E34CD4")]
		set
		{
		}
	}

	[Token(Token = "0x170018D4")]
	internal float _boostInput
	{
		[Token(Token = "0x6017D47")]
		[Address(RVA = "0x1E34CDC", Offset = "0x1E34CDC", VA = "0x1E34CDC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6017D48")]
		[Address(RVA = "0x1E34D38", Offset = "0x1E34D38", VA = "0x1E34D38")]
		set
		{
		}
	}

	[Token(Token = "0x170018D5")]
	public bool IsInWater
	{
		[Token(Token = "0x6017D49")]
		[Address(RVA = "0x1E34D40", Offset = "0x1E34D40", VA = "0x1E34D40", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017D4A")]
		[Address(RVA = "0x1E34D48", Offset = "0x1E34D48", VA = "0x1E34D48", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x170018D6")]
	public float CurEngineRPM
	{
		[Token(Token = "0x6017D4B")]
		[Address(RVA = "0x1E34D50", Offset = "0x1E34D50", VA = "0x1E34D50", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018D7")]
	public VehicleControllerInfo ControllerInfo
	{
		[Token(Token = "0x6017D4C")]
		[Address(RVA = "0x1E34DF0", Offset = "0x1E34DF0", VA = "0x1E34DF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017D32")]
	[Address(RVA = "0x1E343A0", Offset = "0x1E343A0", VA = "0x1E343A0")]
	public RCC_CarControllerV3()
	{
	}

	[Token(Token = "0x6017D3A")]
	[Address(RVA = "0x1E34864", Offset = "0x1E34864", VA = "0x1E34864")]
	public float GetCurrentMaxSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6017D4D")]
	[Address(RVA = "0x1E34F9C", Offset = "0x1E34F9C", VA = "0x1E34F9C", Slot = "21")]
	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	[Token(Token = "0x6017D4E")]
	[Address(RVA = "0x1E350E4", Offset = "0x1E350E4", VA = "0x1E350E4", Slot = "22")]
	public void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	[Token(Token = "0x6017D4F")]
	[Address(RVA = "0x1E35258", Offset = "0x1E35258", VA = "0x1E35258")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6017D50")]
	[Address(RVA = "0x1E35F9C", Offset = "0x1E35F9C", VA = "0x1E35F9C", Slot = "45")]
	public virtual void KillEngine()
	{
	}

	[Token(Token = "0x6017D51")]
	[Address(RVA = "0x1E36014", Offset = "0x1E36014", VA = "0x1E36014", Slot = "46")]
	public virtual void StartEngine()
	{
	}

	[Token(Token = "0x6017D52")]
	[Address(RVA = "0x1E36080", Offset = "0x1E36080", VA = "0x1E36080", Slot = "47")]
	public virtual void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	[Token(Token = "0x6017D53")]
	[Address(RVA = "0x1E3631C", Offset = "0x1E3631C", VA = "0x1E3631C", Slot = "48")]
	public virtual void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	[Token(Token = "0x6017D54")]
	[Address(RVA = "0x1E363C8", Offset = "0x1E363C8", VA = "0x1E363C8", Slot = "31")]
	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6017D55")]
	[Address(RVA = "0x1E36DB0", Offset = "0x1E36DB0", VA = "0x1E36DB0")]
	private void Inputs()
	{
	}

	[Token(Token = "0x6017D56")]
	[Address(RVA = "0x1E36DB4", Offset = "0x1E36DB4", VA = "0x1E36DB4", Slot = "49")]
	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6017D57")]
	[Address(RVA = "0x1E3A528", Offset = "0x1E3A528", VA = "0x1E3A528", Slot = "23")]
	public void SetMaxSpeedScale(float scale)
	{
	}

	[Token(Token = "0x6017D58")]
	[Address(RVA = "0x1E3A530", Offset = "0x1E3A530", VA = "0x1E3A530", Slot = "40")]
	public void SetHightSpeedSteerAngleRate(float rate)
	{
	}

	[Token(Token = "0x6017D59")]
	[Address(RVA = "0x1E3A550", Offset = "0x1E3A550", VA = "0x1E3A550", Slot = "41")]
	public void SetEngineTorqueRate(float rate)
	{
	}

	[Token(Token = "0x6017D5A")]
	[Address(RVA = "0x1E3A570", Offset = "0x1E3A570", VA = "0x1E3A570", Slot = "42")]
	public void SetBrakeTorqueRate(float rate)
	{
	}

	[Token(Token = "0x6017D5B")]
	[Address(RVA = "0x1E3A590", Offset = "0x1E3A590", VA = "0x1E3A590", Slot = "24")]
	public void SetDriverSpeedScale(float scale)
	{
	}

	[Token(Token = "0x6017D5C")]
	[Address(RVA = "0x1E3A598", Offset = "0x1E3A598", VA = "0x1E3A598", Slot = "25")]
	public float GetDriverSpeedScale()
	{
		return default(float);
	}

	[Token(Token = "0x6017D5D")]
	[Address(RVA = "0x1E3A5A0", Offset = "0x1E3A5A0", VA = "0x1E3A5A0", Slot = "26")]
	public void LockMaxSpeed(float speed)
	{
	}

	[Token(Token = "0x6017D5E")]
	[Address(RVA = "0x1E3A5A8", Offset = "0x1E3A5A8", VA = "0x1E3A5A8", Slot = "27")]
	public void UnLockMaxSpeed()
	{
	}

	[Token(Token = "0x6017D5F")]
	[Address(RVA = "0x1E370A8", Offset = "0x1E370A8", VA = "0x1E370A8")]
	private void Engine(float fixedDeltaTime)
	{
	}

	[Token(Token = "0x6017D60")]
	[Address(RVA = "0x1E3A5B8", Offset = "0x1E3A5B8", VA = "0x1E3A5B8")]
	private void ApplyMotorTorque(RCC_WheelCollider wc, float torque)
	{
	}

	[Token(Token = "0x6017D61")]
	[Address(RVA = "0x1E39FF4", Offset = "0x1E39FF4", VA = "0x1E39FF4")]
	private void ESPCheck(float velocity, float steering)
	{
	}

	[Token(Token = "0x6017D62")]
	[Address(RVA = "0x1E36170", Offset = "0x1E36170", VA = "0x1E36170")]
	private void ApplyBrakeTorque(RCC_WheelCollider wc, float brake)
	{
	}

	[Token(Token = "0x6017D63")]
	[Address(RVA = "0x1E38D58", Offset = "0x1E38D58", VA = "0x1E38D58")]
	private void ApplySteering(RCC_WheelCollider wc)
	{
	}

	[Token(Token = "0x6017D64")]
	[Address(RVA = "0x1E37AB8", Offset = "0x1E37AB8", VA = "0x1E37AB8")]
	private void Braking()
	{
	}

	[Token(Token = "0x6017D65")]
	[Address(RVA = "0x1E37D00", Offset = "0x1E37D00", VA = "0x1E37D00")]
	private void AntiRollBars()
	{
	}

	[Token(Token = "0x6017D66")]
	[Address(RVA = "0x1E38F38", Offset = "0x1E38F38", VA = "0x1E38F38")]
	private void SteerHelper()
	{
	}

	[Token(Token = "0x6017D67")]
	[Address(RVA = "0x1E39BE0", Offset = "0x1E39BE0", VA = "0x1E39BE0")]
	private void TractionHelper()
	{
	}

	[Token(Token = "0x6017D68")]
	[Address(RVA = "0x1E36890", Offset = "0x1E36890", VA = "0x1E36890")]
	private void Clutch(float deltaTime)
	{
	}

	[Token(Token = "0x6017D69")]
	[Address(RVA = "0x1E36454", Offset = "0x1E36454", VA = "0x1E36454")]
	private void GearBox()
	{
	}

	[Token(Token = "0x6017D6A")]
	[Address(RVA = "0x1E3AB0C", Offset = "0x1E3AB0C", VA = "0x1E3AB0C")]
	internal IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	[Token(Token = "0x6017D6B")]
	[Address(RVA = "0x1E38D0C", Offset = "0x1E38D0C", VA = "0x1E38D0C")]
	private void RevLimiter()
	{
	}

	[Token(Token = "0x6017D6C")]
	[Address(RVA = "0x1E36B44", Offset = "0x1E36B44", VA = "0x1E36B44")]
	private void Turbo()
	{
	}

	[Token(Token = "0x6017D6D")]
	[Address(RVA = "0x1E38BB0", Offset = "0x1E38BB0", VA = "0x1E38BB0")]
	private void DriftVariables()
	{
	}

	[Token(Token = "0x6017D6E")]
	[Address(RVA = "0x1E36B48", Offset = "0x1E36B48", VA = "0x1E36B48")]
	private void ResetCar(float deltaTime)
	{
	}

	[Token(Token = "0x6017D6F")]
	[Address(RVA = "0x1E3AAB4", Offset = "0x1E3AAB4", VA = "0x1E3AAB4")]
	private bool OverTorque()
	{
		return default(bool);
	}

	[Token(Token = "0x6017D70")]
	[Address(RVA = "0x1E356F0", Offset = "0x1E356F0", VA = "0x1E356F0")]
	public void TorqueCurve()
	{
	}

	[Token(Token = "0x6017D71")]
	[Address(RVA = "0x1E3ABB4", Offset = "0x1E3ABB4", VA = "0x1E3ABB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6017D72")]
	[Address(RVA = "0x1E3ABB8", Offset = "0x1E3ABB8", VA = "0x1E3ABB8", Slot = "28")]
	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	[Token(Token = "0x6017D73")]
	[Address(RVA = "0x1E3ADF8", Offset = "0x1E3ADF8", VA = "0x1E3ADF8", Slot = "29")]
	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	[Token(Token = "0x6017D74")]
	[Address(RVA = "0x1E3AEC8", Offset = "0x1E3AEC8", VA = "0x1E3AEC8", Slot = "36")]
	public int GetWheelType(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6017D75")]
	[Address(RVA = "0x1E3B0D4", Offset = "0x1E3B0D4", VA = "0x1E3B0D4", Slot = "15")]
	public float CaculateVehicleRevs()
	{
		return default(float);
	}

	[Token(Token = "0x6017D76")]
	[Address(RVA = "0x1E3B2C0", Offset = "0x1E3B2C0", VA = "0x1E3B2C0", Slot = "37")]
	public void StartBoost(float torque, float maxSpeed, float angle)
	{
	}

	[Token(Token = "0x6017D77")]
	[Address(RVA = "0x1E35FE4", Offset = "0x1E35FE4", VA = "0x1E35FE4", Slot = "38")]
	public void StopBoost()
	{
	}

	[Token(Token = "0x6017D78")]
	[Address(RVA = "0x1E3B4C8", Offset = "0x1E3B4C8", VA = "0x1E3B4C8", Slot = "20")]
	public void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	[Token(Token = "0x6017D79")]
	[Address(RVA = "0x1E3C2C8", Offset = "0x1E3C2C8", VA = "0x1E3C2C8", Slot = "39")]
	public void SetJumpHeightRate(float rate)
	{
	}

	[Token(Token = "0x6017D7A")]
	[Address(RVA = "0x1E3C2CC", Offset = "0x1E3C2CC", VA = "0x1E3C2CC", Slot = "43")]
	public void ForceStop()
	{
	}
}
