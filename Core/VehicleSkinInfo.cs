using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D0D")]
public class VehicleSkinInfo : VehicleSkinInfoBase
{
	[Token(Token = "0x2003D0E")]
	public enum TailAnimState
	{
		[Token(Token = "0x4019E8D")]
		DownFirstState = 1,
		[Token(Token = "0x4019E8E")]
		DownSecondState,
		[Token(Token = "0x4019E8F")]
		UpFirstState,
		[Token(Token = "0x4019E90")]
		UpSecondState
	}

	[Token(Token = "0x4019E83")]
	[FieldOffset(Offset = "0x84")]
	public Transform VehicleBodyModel;

	[Token(Token = "0x4019E84")]
	[FieldOffset(Offset = "0x88")]
	public Transform VehicleBrakeLight;

	[Token(Token = "0x4019E85")]
	[FieldOffset(Offset = "0x8C")]
	public Transform VehicleSteeringWheel;

	[Token(Token = "0x4019E86")]
	[FieldOffset(Offset = "0x90")]
	public Transform FrontLeftWheelModel;

	[Token(Token = "0x4019E87")]
	[FieldOffset(Offset = "0x94")]
	public Transform FrontRightWheelModel;

	[Token(Token = "0x4019E88")]
	[FieldOffset(Offset = "0x98")]
	public Transform RearLeftWheelModel;

	[Token(Token = "0x4019E89")]
	[FieldOffset(Offset = "0x9C")]
	public Transform RearRightWheelModel;

	[Token(Token = "0x4019E8A")]
	[FieldOffset(Offset = "0xA0")]
	private int AnimState;

	[Token(Token = "0x4019E8B")]
	[FieldOffset(Offset = "0xA4")]
	private List<Transform> m_WheelModels;

	[Token(Token = "0x170019E1")]
	public override Transform BodyModel
	{
		[Token(Token = "0x601873B")]
		[Address(RVA = "0x2A694AC", Offset = "0x2A694AC", VA = "0x2A694AC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019E2")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x601873C")]
		[Address(RVA = "0x2A694B4", Offset = "0x2A694B4", VA = "0x2A694B4", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601873A")]
	[Address(RVA = "0x2A69494", Offset = "0x2A69494", VA = "0x2A69494")]
	public VehicleSkinInfo()
	{
	}

	[Token(Token = "0x601873D")]
	[Address(RVA = "0x2A6962C", Offset = "0x2A6962C", VA = "0x2A6962C", Slot = "6")]
	public override void SetSkinState(bool is_show)
	{
	}

	[Token(Token = "0x601873E")]
	[Address(RVA = "0x2A69928", Offset = "0x2A69928", VA = "0x2A69928", Slot = "7")]
	public override void ClearSkinAttached()
	{
	}

	[Token(Token = "0x601873F")]
	[Address(RVA = "0x2A69BF0", Offset = "0x2A69BF0", VA = "0x2A69BF0", Slot = "8")]
	public override void EnableBrakeLightsEffect(bool enable)
	{
	}

	[Token(Token = "0x6018740")]
	[Address(RVA = "0x2A69CCC", Offset = "0x2A69CCC", VA = "0x2A69CCC", Slot = "9")]
	public override void EnableTailAimi(int state)
	{
	}
}
