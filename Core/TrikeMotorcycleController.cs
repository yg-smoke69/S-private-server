using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D05")]
public class TrikeMotorcycleController : RMCRealisticMotorcycleController
{
	[Token(Token = "0x4006954")]
	[FieldOffset(Offset = "0x11C")]
	public MotorcycleWheelController SideWheelCollider;

	[Token(Token = "0x4006955")]
	[FieldOffset(Offset = "0x120")]
	protected float RotationValue3;

	[Token(Token = "0x4006956")]
	[FieldOffset(Offset = "0x124")]
	protected Transform SideWheelColliderTrans;

	[Token(Token = "0x4006957")]
	[FieldOffset(Offset = "0x128")]
	public float SideWheelLeanThreshold;

	[Token(Token = "0x4006958")]
	[FieldOffset(Offset = "0x12C")]
	private float m_ChassisBaseHeight;

	[Token(Token = "0x4006959")]
	[FieldOffset(Offset = "0x130")]
	private float m_RearWheersDistance;

	[Token(Token = "0x400695A")]
	[FieldOffset(Offset = "0x134")]
	public float LeanPosAdjustFactor;

	[Token(Token = "0x400695B")]
	[FieldOffset(Offset = "0x138")]
	public float antiRollRearHorizontal;

	[Token(Token = "0x400695C")]
	[FieldOffset(Offset = "0x13C")]
	public bool RotateSteeringHandlerAlongGlobalY;

	[Token(Token = "0x400695D")]
	private const float EngineRpmMul = (float)Math.PI * 3f / 50f;

	[Token(Token = "0x1700084F")]
	public override bool IsGrounded
	{
		[Token(Token = "0x600634F")]
		[Address(RVA = "0x263CF1C", Offset = "0x263CF1C", VA = "0x263CF1C", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000850")]
	public override List<WheelColliderInterface> WheelColliders
	{
		[Token(Token = "0x6006350")]
		[Address(RVA = "0x263D218", Offset = "0x263D218", VA = "0x263D218", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600634E")]
	[Address(RVA = "0x263CEE8", Offset = "0x263CEE8", VA = "0x263CEE8")]
	public TrikeMotorcycleController()
	{
	}

	[Token(Token = "0x6006351")]
	[Address(RVA = "0x263D35C", Offset = "0x263D35C", VA = "0x263D35C", Slot = "56")]
	public override int GetWheelType(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x6006352")]
	[Address(RVA = "0x263D4FC", Offset = "0x263D4FC", VA = "0x263D4FC", Slot = "46")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6006353")]
	[Address(RVA = "0x263D814", Offset = "0x263D814", VA = "0x263D814", Slot = "47")]
	public override void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6006354")]
	[Address(RVA = "0x263DCBC", Offset = "0x263DCBC", VA = "0x263DCBC", Slot = "48")]
	protected override void InputHandle()
	{
	}

	[Token(Token = "0x6006355")]
	[Address(RVA = "0x263DDBC", Offset = "0x263DDBC", VA = "0x263DDBC", Slot = "49")]
	protected override void Engine()
	{
	}

	[Token(Token = "0x6006356")]
	[Address(RVA = "0x263E070", Offset = "0x263E070", VA = "0x263E070", Slot = "50")]
	protected override void ApplyMotorTorque()
	{
	}

	[Token(Token = "0x6006357")]
	[Address(RVA = "0x263E3EC", Offset = "0x263E3EC", VA = "0x263E3EC")]
	private void ApplyMotorTorque(WheelCollider wheel, float torque)
	{
	}

	[Token(Token = "0x6006358")]
	[Address(RVA = "0x263E420", Offset = "0x263E420", VA = "0x263E420", Slot = "51")]
	public override void Braking()
	{
	}

	[Token(Token = "0x6006359")]
	[Address(RVA = "0x263E7C4", Offset = "0x263E7C4", VA = "0x263E7C4", Slot = "52")]
	protected override void WheelAlign()
	{
	}

	[Token(Token = "0x600635A")]
	[Address(RVA = "0x263E830", Offset = "0x263E830", VA = "0x263E830")]
	private void WheelAlign(WheelCollider wheelCol, Transform wheelColTrans, Transform wheelTrans, ref float rot)
	{
	}

	[Token(Token = "0x600635B")]
	[Address(RVA = "0x263EEC0", Offset = "0x263EEC0", VA = "0x263EEC0", Slot = "53")]
	protected override void RotateHandlebarFenders()
	{
	}

	[Token(Token = "0x600635C")]
	[Address(RVA = "0x263F190", Offset = "0x263F190", VA = "0x263F190", Slot = "54")]
	protected override void Lean()
	{
	}

	[Token(Token = "0x600635D")]
	[Address(RVA = "0x263D834", Offset = "0x263D834", VA = "0x263D834")]
	private void AntiRollBars()
	{
	}

	[Token(Token = "0x600635E")]
	[Address(RVA = "0x263F2D4", Offset = "0x263F2D4", VA = "0x263F2D4", Slot = "55")]
	public override void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}
}
