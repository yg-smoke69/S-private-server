using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BC7")]
public class RMCRealisticMotorcycleController : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2003BC8")]
	private sealed class _003CChangingGear_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019809")]
		[FieldOffset(Offset = "0x8")]
		internal int gear;

		[Token(Token = "0x401980A")]
		[FieldOffset(Offset = "0xC")]
		internal RMCRealisticMotorcycleController _0024this;

		[Token(Token = "0x401980B")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x401980C")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x401980D")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170018EF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017DE4")]
			[Address(RVA = "0x3155270", Offset = "0x3155270", VA = "0x3155270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170018F0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017DE5")]
			[Address(RVA = "0x3155278", Offset = "0x3155278", VA = "0x3155278", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017DE2")]
		[Address(RVA = "0x3153CA4", Offset = "0x3153CA4", VA = "0x3153CA4")]
		public _003CChangingGear_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6017DE3")]
		[Address(RVA = "0x3155154", Offset = "0x3155154", VA = "0x3155154", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017DE6")]
		[Address(RVA = "0x3155280", Offset = "0x3155280", VA = "0x3155280", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017DE7")]
		[Address(RVA = "0x3155294", Offset = "0x3155294", VA = "0x3155294", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40197C2")]
	[FieldOffset(Offset = "0xC")]
	protected bool engineRunning;

	[Token(Token = "0x40197C3")]
	[FieldOffset(Offset = "0xD")]
	public bool TryResetCar;

	[Token(Token = "0x40197C4")]
	[FieldOffset(Offset = "0x10")]
	private float resetTime;

	[Token(Token = "0x40197C5")]
	[FieldOffset(Offset = "0x14")]
	protected Rigidbody rigid;

	[Token(Token = "0x40197C6")]
	[FieldOffset(Offset = "0x18")]
	public MotorcycleWheelController FrontWheelCollider;

	[Token(Token = "0x40197C7")]
	[FieldOffset(Offset = "0x1C")]
	public MotorcycleWheelController RearWheelCollider;

	[Token(Token = "0x40197C8")]
	[FieldOffset(Offset = "0x20")]
	public Transform Fender;

	[Token(Token = "0x40197C9")]
	[FieldOffset(Offset = "0x24")]
	public Transform SteeringHandlebar;

	[Token(Token = "0x40197CA")]
	[FieldOffset(Offset = "0x28")]
	public Transform FenderContainer;

	[Token(Token = "0x40197CB")]
	[FieldOffset(Offset = "0x2C")]
	public Transform SteeringHandlebarContainer;

	[Token(Token = "0x40197CC")]
	[FieldOffset(Offset = "0x30")]
	public Transform COM;

	[Token(Token = "0x40197CD")]
	[FieldOffset(Offset = "0x34")]
	public Transform SkinContainer;

	[Token(Token = "0x40197CE")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_ReachSpeedAndTurnMax;

	[Token(Token = "0x40197CF")]
	[FieldOffset(Offset = "0x3C")]
	protected List<WheelColliderInterface> m_WheelColliders;

	[Token(Token = "0x40197D0")]
	[FieldOffset(Offset = "0x40")]
	protected Transform FrontWheelColliderTrans;

	[Token(Token = "0x40197D1")]
	[FieldOffset(Offset = "0x44")]
	protected Transform RearWheelColliderTrans;

	[Token(Token = "0x40197D2")]
	[FieldOffset(Offset = "0x48")]
	public bool changingGear;

	[Token(Token = "0x40197D3")]
	[FieldOffset(Offset = "0x4C")]
	public float gearShiftRate;

	[Token(Token = "0x40197D4")]
	[FieldOffset(Offset = "0x50")]
	public float[] gearSpeed;

	[Token(Token = "0x40197D5")]
	[FieldOffset(Offset = "0x54")]
	public int currentGear;

	[Token(Token = "0x40197D6")]
	[FieldOffset(Offset = "0x58")]
	public int totalGears;

	[Token(Token = "0x40197D7")]
	[FieldOffset(Offset = "0x5C")]
	public Transform chassis;

	[Token(Token = "0x40197D8")]
	[FieldOffset(Offset = "0x60")]
	public float chassisVerticalLean;

	[Token(Token = "0x40197D9")]
	[FieldOffset(Offset = "0x64")]
	public float chassisHorizontalLean;

	[Token(Token = "0x40197DA")]
	[FieldOffset(Offset = "0x68")]
	protected float horizontalLean;

	[Token(Token = "0x40197DB")]
	[FieldOffset(Offset = "0x6C")]
	protected float verticalLean;

	[Token(Token = "0x40197DC")]
	[FieldOffset(Offset = "0x70")]
	public float MaxVerticalLean;

	[Token(Token = "0x40197DD")]
	[FieldOffset(Offset = "0x74")]
	public float MaxHorizontalLean;

	[Token(Token = "0x40197DE")]
	[FieldOffset(Offset = "0x78")]
	public float ChassisLenLerpFactor;

	[Token(Token = "0x40197DF")]
	[FieldOffset(Offset = "0x7C")]
	public AnimationCurve[] engineTorqueCurve;

	[Token(Token = "0x40197E0")]
	[FieldOffset(Offset = "0x80")]
	public float EngineTorque;

	[Token(Token = "0x40197E1")]
	[FieldOffset(Offset = "0x84")]
	public float MaxEngineRPM;

	[Token(Token = "0x40197E2")]
	[FieldOffset(Offset = "0x88")]
	public float MinEngineRPM;

	[Token(Token = "0x40197E3")]
	[FieldOffset(Offset = "0x8C")]
	public float m_SteerAngle;

	[Token(Token = "0x40197E4")]
	[FieldOffset(Offset = "0x90")]
	public int SpeedSteerAudio;

	[Token(Token = "0x40197E5")]
	[FieldOffset(Offset = "0x94")]
	public string SpeedSteerAudioResID;

	[Token(Token = "0x40197E6")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isBoosting;

	[Token(Token = "0x40197E7")]
	[FieldOffset(Offset = "0x9C")]
	private float m_maxSpeedBackup;

	[Token(Token = "0x40197E8")]
	[FieldOffset(Offset = "0xA0")]
	private float m_engineTorqueBackup;

	[Token(Token = "0x40197E9")]
	[FieldOffset(Offset = "0xA4")]
	private float m_highSpeedSteerAngleBackup;

	[Token(Token = "0x40197EA")]
	[FieldOffset(Offset = "0xA8")]
	private float m_EPSILON;

	[Token(Token = "0x40197EB")]
	[FieldOffset(Offset = "0xAC")]
	protected float Speed;

	[Token(Token = "0x40197EC")]
	[FieldOffset(Offset = "0xB0")]
	public float highSpeedSteerAngle;

	[Token(Token = "0x40197ED")]
	[FieldOffset(Offset = "0xB4")]
	public float highSpeedSteerAngleAtSpeed;

	[Token(Token = "0x40197EE")]
	[FieldOffset(Offset = "0xB8")]
	public float maxSpeed;

	[Token(Token = "0x40197EF")]
	[FieldOffset(Offset = "0xBC")]
	public float Brake;

	[Token(Token = "0x40197F0")]
	[FieldOffset(Offset = "0xC0")]
	protected float EngineRPM;

	[Token(Token = "0x40197F1")]
	[FieldOffset(Offset = "0xC4")]
	protected float motorInput;

	[Token(Token = "0x40197F2")]
	[FieldOffset(Offset = "0xC8")]
	protected float defsteerAngle;

	[Token(Token = "0x40197F3")]
	[FieldOffset(Offset = "0xCC")]
	protected float RotationValue1;

	[Token(Token = "0x40197F4")]
	[FieldOffset(Offset = "0xD0")]
	protected float RotationValue2;

	[Token(Token = "0x40197F5")]
	[FieldOffset(Offset = "0xD4")]
	private bool mModelVisible;

	[Token(Token = "0x40197F6")]
	[FieldOffset(Offset = "0xD5")]
	public bool UpdateWheelTransforms;

	[Token(Token = "0x40197F7")]
	[FieldOffset(Offset = "0xD8")]
	public float IdleBrakeInput;

	[Token(Token = "0x40197F8")]
	[FieldOffset(Offset = "0xDC")]
	public bool brakingNow;

	[Token(Token = "0x40197F9")]
	[FieldOffset(Offset = "0xE0")]
	protected float steerInput;

	[Token(Token = "0x40197FA")]
	[FieldOffset(Offset = "0xE4")]
	public bool crashed;

	[Token(Token = "0x40197FB")]
	[FieldOffset(Offset = "0xE5")]
	protected bool reversing;

	[Token(Token = "0x40197FC")]
	[FieldOffset(Offset = "0xE8")]
	protected float mSpeedScale;

	[Token(Token = "0x40197FD")]
	[FieldOffset(Offset = "0xEC")]
	protected float mDriverSpeedScale;

	[Token(Token = "0x40197FE")]
	[FieldOffset(Offset = "0xF0")]
	public LayerMask ColliderMask;

	[Token(Token = "0x40197FF")]
	[FieldOffset(Offset = "0xF4")]
	public float ReverseMaxSpeed;

	[Token(Token = "0x4019800")]
	[FieldOffset(Offset = "0xF8")]
	public float ReverseTorqueScale;

	[Token(Token = "0x4019801")]
	[FieldOffset(Offset = "0xFC")]
	protected TssSdtFloat mHighSpeedSteerAngleRate;

	[Token(Token = "0x4019802")]
	[FieldOffset(Offset = "0x100")]
	protected TssSdtFloat mEngineTorqueRate;

	[Token(Token = "0x4019803")]
	[FieldOffset(Offset = "0x104")]
	protected TssSdtFloat mBrakeTorqueRate;

	[Token(Token = "0x4019804")]
	[FieldOffset(Offset = "0x108")]
	private bool m_IsInWater;

	[Token(Token = "0x4019805")]
	[FieldOffset(Offset = "0x10C")]
	protected float m_GearFactor;

	[Token(Token = "0x4019806")]
	[FieldOffset(Offset = "0x110")]
	public bool Enable3PSimulate;

	[Token(Token = "0x4019807")]
	[FieldOffset(Offset = "0x114")]
	protected float m_LockSpeed;

	[Token(Token = "0x4019808")]
	[FieldOffset(Offset = "0x118")]
	public float CurrentSteerAngle;

	[Token(Token = "0x170018E0")]
	public Transform VehicleCOM
	{
		[Token(Token = "0x6017DA6")]
		[Address(RVA = "0x31504DC", Offset = "0x31504DC", VA = "0x31504DC", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E1")]
	public bool ReachSpeedAndTurnMax
	{
		[Token(Token = "0x6017DA7")]
		[Address(RVA = "0x31504E4", Offset = "0x31504E4", VA = "0x31504E4", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018E2")]
	public virtual List<WheelColliderInterface> WheelColliders
	{
		[Token(Token = "0x6017DA8")]
		[Address(RVA = "0x31504EC", Offset = "0x31504EC", VA = "0x31504EC", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E3")]
	private int _totalGears
	{
		[Token(Token = "0x6017DA9")]
		[Address(RVA = "0x31505FC", Offset = "0x31505FC", VA = "0x31505FC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018E4")]
	public float SteerAngle
	{
		[Token(Token = "0x6017DAA")]
		[Address(RVA = "0x3150608", Offset = "0x3150608", VA = "0x3150608", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018E5")]
	public float Velocity
	{
		[Token(Token = "0x6017DAB")]
		[Address(RVA = "0x3150610", Offset = "0x3150610", VA = "0x3150610", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018E6")]
	public float CurEngineRPM
	{
		[Token(Token = "0x6017DAC")]
		[Address(RVA = "0x3150618", Offset = "0x3150618", VA = "0x3150618", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018E7")]
	public bool ModelVisible
	{
		[Token(Token = "0x6017DAE")]
		[Address(RVA = "0x31506C0", Offset = "0x31506C0", VA = "0x31506C0", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017DAD")]
		[Address(RVA = "0x31506B8", Offset = "0x31506B8", VA = "0x31506B8", Slot = "4")]
		set
		{
		}
	}

	[Token(Token = "0x170018E8")]
	public float GasInput
	{
		[Token(Token = "0x6017DAF")]
		[Address(RVA = "0x31506C8", Offset = "0x31506C8", VA = "0x31506C8", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018E9")]
	public float BrakeInput
	{
		[Token(Token = "0x6017DB0")]
		[Address(RVA = "0x3150758", Offset = "0x3150758", VA = "0x3150758", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018EA")]
	public float SteerInput
	{
		[Token(Token = "0x6017DB1")]
		[Address(RVA = "0x31507EC", Offset = "0x31507EC", VA = "0x31507EC", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170018EB")]
	public int Direction
	{
		[Token(Token = "0x6017DB2")]
		[Address(RVA = "0x31507F4", Offset = "0x31507F4", VA = "0x31507F4", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018EC")]
	public virtual bool IsGrounded
	{
		[Token(Token = "0x6017DB3")]
		[Address(RVA = "0x3150808", Offset = "0x3150808", VA = "0x3150808", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018ED")]
	public bool IsInWater
	{
		[Token(Token = "0x6017DB4")]
		[Address(RVA = "0x3150A20", Offset = "0x3150A20", VA = "0x3150A20", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017DB5")]
		[Address(RVA = "0x3150A28", Offset = "0x3150A28", VA = "0x3150A28", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x170018EE")]
	public VehicleControllerInfo ControllerInfo
	{
		[Token(Token = "0x6017DB6")]
		[Address(RVA = "0x3150A30", Offset = "0x3150A30", VA = "0x3150A30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017DA5")]
	[Address(RVA = "0x3150310", Offset = "0x3150310", VA = "0x3150310")]
	public RMCRealisticMotorcycleController()
	{
	}

	[Token(Token = "0x6017DB7")]
	[Address(RVA = "0x3150BA4", Offset = "0x3150BA4", VA = "0x3150BA4", Slot = "21")]
	public void SetControllerInfo(VehicleControllerInfo i)
	{
	}

	[Token(Token = "0x6017DB8")]
	[Address(RVA = "0x3150CB4", Offset = "0x3150CB4", VA = "0x3150CB4", Slot = "46")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6017DB9")]
	[Address(RVA = "0x3150CBC", Offset = "0x3150CBC", VA = "0x3150CBC")]
	private void InitInNeed()
	{
	}

	[Token(Token = "0x6017DBA")]
	[Address(RVA = "0x3151018", Offset = "0x3151018", VA = "0x3151018")]
	public AudioSource CreateAudioSource(string audioName, float minDistance, float volume, AudioClip audioClip, bool loop, bool playNow, bool destroyAfterFinished)
	{
		return null;
	}

	[Token(Token = "0x6017DBB")]
	[Address(RVA = "0x3150CB8", Offset = "0x3150CB8", VA = "0x3150CB8")]
	public void SoundsInitialize()
	{
	}

	[Token(Token = "0x6017DBC")]
	[Address(RVA = "0x3151484", Offset = "0x3151484", VA = "0x3151484", Slot = "47")]
	public virtual void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6017DBD")]
	[Address(RVA = "0x315172C", Offset = "0x315172C", VA = "0x315172C", Slot = "23")]
	public void SetMaxSpeedScale(float scale)
	{
	}

	[Token(Token = "0x6017DBE")]
	[Address(RVA = "0x3151734", Offset = "0x3151734", VA = "0x3151734", Slot = "40")]
	public void SetHightSpeedSteerAngleRate(float rate)
	{
	}

	[Token(Token = "0x6017DBF")]
	[Address(RVA = "0x3151754", Offset = "0x3151754", VA = "0x3151754", Slot = "41")]
	public void SetEngineTorqueRate(float rate)
	{
	}

	[Token(Token = "0x6017DC0")]
	[Address(RVA = "0x3151774", Offset = "0x3151774", VA = "0x3151774", Slot = "42")]
	public void SetBrakeTorqueRate(float rate)
	{
	}

	[Token(Token = "0x6017DC1")]
	[Address(RVA = "0x3151794", Offset = "0x3151794", VA = "0x3151794", Slot = "24")]
	public void SetDriverSpeedScale(float scale)
	{
	}

	[Token(Token = "0x6017DC2")]
	[Address(RVA = "0x315179C", Offset = "0x315179C", VA = "0x315179C", Slot = "25")]
	public float GetDriverSpeedScale()
	{
		return default(float);
	}

	[Token(Token = "0x6017DC3")]
	[Address(RVA = "0x31517A4", Offset = "0x31517A4", VA = "0x31517A4", Slot = "26")]
	public void LockMaxSpeed(float speed)
	{
	}

	[Token(Token = "0x6017DC4")]
	[Address(RVA = "0x31517AC", Offset = "0x31517AC", VA = "0x31517AC", Slot = "27")]
	public void UnLockMaxSpeed()
	{
	}

	[Token(Token = "0x6017DC5")]
	[Address(RVA = "0x31517BC", Offset = "0x31517BC", VA = "0x31517BC")]
	public float GetCurrentMaxSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6017DC6")]
	[Address(RVA = "0x31517D8", Offset = "0x31517D8", VA = "0x31517D8", Slot = "31")]
	public void VehicleLasyUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6017DC7")]
	[Address(RVA = "0x315183C", Offset = "0x315183C", VA = "0x315183C")]
	private void ResetCar(float deltaTime)
	{
	}

	[Token(Token = "0x6017DC8")]
	[Address(RVA = "0x3151B08", Offset = "0x3151B08", VA = "0x3151B08", Slot = "48")]
	protected virtual void InputHandle()
	{
	}

	[Token(Token = "0x6017DC9")]
	[Address(RVA = "0x3151D24", Offset = "0x3151D24", VA = "0x3151D24", Slot = "28")]
	public void UpdateVehicleSpeed(float rpm, float velocity)
	{
	}

	[Token(Token = "0x6017DCA")]
	[Address(RVA = "0x3151F40", Offset = "0x3151F40", VA = "0x3151F40", Slot = "29")]
	public void UpdateVehicleSteerAngle(float steerAngle)
	{
	}

	[Token(Token = "0x6017DCB")]
	[Address(RVA = "0x3151FC8", Offset = "0x3151FC8", VA = "0x3151FC8", Slot = "32")]
	public void VehicleUpdateInput(bool gas, bool brake, Vector3 steer)
	{
	}

	[Token(Token = "0x6017DCC")]
	[Address(RVA = "0x31520B4", Offset = "0x31520B4", VA = "0x31520B4", Slot = "33")]
	public void VehicleUpdateInput(float gas, float brake, Vector3 steer)
	{
	}

	[Token(Token = "0x6017DCD")]
	[Address(RVA = "0x3152178", Offset = "0x3152178", VA = "0x3152178", Slot = "49")]
	protected virtual void Engine()
	{
	}

	[Token(Token = "0x6017DCE")]
	[Address(RVA = "0x31523F4", Offset = "0x31523F4", VA = "0x31523F4", Slot = "50")]
	protected virtual void ApplyMotorTorque()
	{
	}

	[Token(Token = "0x6017DCF")]
	[Address(RVA = "0x315271C", Offset = "0x315271C", VA = "0x315271C", Slot = "51")]
	public virtual void Braking()
	{
	}

	[Token(Token = "0x6017DD0")]
	[Address(RVA = "0x31529EC", Offset = "0x31529EC", VA = "0x31529EC", Slot = "52")]
	protected virtual void WheelAlign()
	{
	}

	[Token(Token = "0x6017DD1")]
	[Address(RVA = "0x3153A48", Offset = "0x3153A48", VA = "0x3153A48", Slot = "53")]
	protected virtual void RotateHandlebarFenders()
	{
	}

	[Token(Token = "0x6017DD2")]
	[Address(RVA = "0x3151508", Offset = "0x3151508", VA = "0x3151508")]
	public void ShiftGears()
	{
	}

	[Token(Token = "0x6017DD3")]
	[Address(RVA = "0x3153C04", Offset = "0x3153C04", VA = "0x3153C04")]
	private IEnumerator ChangingGear(int gear)
	{
		return null;
	}

	[Token(Token = "0x6017DD4")]
	[Address(RVA = "0x3153CAC", Offset = "0x3153CAC", VA = "0x3153CAC", Slot = "54")]
	protected virtual void Lean()
	{
	}

	[Token(Token = "0x6017DD5")]
	[Address(RVA = "0x3151728", Offset = "0x3151728", VA = "0x3151728")]
	public void SkidAudio()
	{
	}

	[Token(Token = "0x6017DD6")]
	[Address(RVA = "0x315426C", Offset = "0x315426C", VA = "0x315426C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6017DD7")]
	[Address(RVA = "0x3154270", Offset = "0x3154270", VA = "0x3154270", Slot = "55")]
	public virtual void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	[Token(Token = "0x6017DD8")]
	[Address(RVA = "0x31542F4", Offset = "0x31542F4", VA = "0x31542F4", Slot = "34")]
	public void KillEngine()
	{
	}

	[Token(Token = "0x6017DD9")]
	[Address(RVA = "0x3154364", Offset = "0x3154364", VA = "0x3154364", Slot = "35")]
	public void StartEngine()
	{
	}

	[Token(Token = "0x6017DDA")]
	[Address(RVA = "0x31543C8", Offset = "0x31543C8", VA = "0x31543C8", Slot = "56")]
	public virtual int GetWheelType(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6017DDB")]
	[Address(RVA = "0x3151E54", Offset = "0x3151E54", VA = "0x3151E54")]
	private int GetGearBySpeed(float velocity)
	{
		return default(int);
	}

	[Token(Token = "0x6017DDC")]
	[Address(RVA = "0x31544F8", Offset = "0x31544F8", VA = "0x31544F8", Slot = "15")]
	public float CaculateVehicleRevs()
	{
		return default(float);
	}

	[Token(Token = "0x6017DDD")]
	[Address(RVA = "0x3154644", Offset = "0x3154644", VA = "0x3154644", Slot = "37")]
	public void StartBoost(float torque, float maxSpeed, float angle)
	{
	}

	[Token(Token = "0x6017DDE")]
	[Address(RVA = "0x3154334", Offset = "0x3154334", VA = "0x3154334", Slot = "38")]
	public void StopBoost()
	{
	}

	[Token(Token = "0x6017DDF")]
	[Address(RVA = "0x3154854", Offset = "0x3154854", VA = "0x3154854", Slot = "57")]
	public virtual void BindVehicleSkin(VehicleSkinInfoBase skin_info)
	{
	}

	[Token(Token = "0x6017DE0")]
	[Address(RVA = "0x3155090", Offset = "0x3155090", VA = "0x3155090", Slot = "39")]
	public void SetJumpHeightRate(float rate)
	{
	}

	[Token(Token = "0x6017DE1")]
	[Address(RVA = "0x3155094", Offset = "0x3155094", VA = "0x3155094", Slot = "43")]
	public void ForceStop()
	{
	}
}
