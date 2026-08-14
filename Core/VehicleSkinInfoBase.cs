using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D0C")]
public abstract class VehicleSkinInfoBase : MonoBehaviour
{
	[Token(Token = "0x4019E73")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CSkinResID_003Ek__BackingField;

	[Token(Token = "0x4019E74")]
	[FieldOffset(Offset = "0x10")]
	public Animation TailAni;

	[Token(Token = "0x4019E75")]
	[FieldOffset(Offset = "0x14")]
	public int FirstAniSpeed;

	[Token(Token = "0x4019E76")]
	[FieldOffset(Offset = "0x18")]
	public int SecondAniSpeed;

	[Token(Token = "0x4019E77")]
	[FieldOffset(Offset = "0x1C")]
	public string BoostEndEffectRes;

	[Token(Token = "0x4019E78")]
	[FieldOffset(Offset = "0x20")]
	public string BoostStartEffectRes;

	[Token(Token = "0x4019E79")]
	[FieldOffset(Offset = "0x24")]
	public string BoostLoopEffectRes;

	[Token(Token = "0x4019E7A")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 LeftFrontWheel;

	[Token(Token = "0x4019E7B")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 RightFrontWheel;

	[Token(Token = "0x4019E7C")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 LeftBottomWheel;

	[Token(Token = "0x4019E7D")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 RightBottomWheel;

	[Token(Token = "0x4019E7E")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 DriveSeat;

	[Token(Token = "0x4019E7F")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 PassengerSeat;

	[Token(Token = "0x4019E80")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 SteeringWheel;

	[Token(Token = "0x4019E81")]
	[FieldOffset(Offset = "0x7C")]
	public string GearVFX;

	[Token(Token = "0x4019E82")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RunningVFX;

	[Token(Token = "0x170019DE")]
	public uint SkinResID
	{
		[Token(Token = "0x6018732")]
		[Address(RVA = "0x2A69EA4", Offset = "0x2A69EA4", VA = "0x2A69EA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018733")]
		[Address(RVA = "0x2A69EAC", Offset = "0x2A69EAC", VA = "0x2A69EAC")]
		set
		{
		}
	}

	[Token(Token = "0x170019DF")]
	public abstract Transform BodyModel
	{
		[Token(Token = "0x6018734")]
		get;
	}

	[Token(Token = "0x170019E0")]
	public abstract List<Transform> WheelModels
	{
		[Token(Token = "0x6018735")]
		get;
	}

	[Token(Token = "0x6018731")]
	[Address(RVA = "0x2A694A4", Offset = "0x2A694A4", VA = "0x2A694A4")]
	protected VehicleSkinInfoBase()
	{
	}

	[Token(Token = "0x6018736")]
	public abstract void SetSkinState(bool is_show);

	[Token(Token = "0x6018737")]
	public abstract void ClearSkinAttached();

	[Token(Token = "0x6018738")]
	public abstract void EnableBrakeLightsEffect(bool enable);

	[Token(Token = "0x6018739")]
	public abstract void EnableTailAimi(int state);
}
