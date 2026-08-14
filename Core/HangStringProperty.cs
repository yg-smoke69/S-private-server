using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B6F")]
public class HangStringProperty : ScriptableObject
{
	[Token(Token = "0x401952A")]
	[FieldOffset(Offset = "0xC")]
	public int CalcPriorityId;

	[Token(Token = "0x401952B")]
	[FieldOffset(Offset = "0x10")]
	public string StringFirstBonTrans;

	[Token(Token = "0x401952C")]
	[FieldOffset(Offset = "0x14")]
	public float Hardness;

	[Token(Token = "0x401952D")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve HardnessCurve;

	[Token(Token = "0x401952E")]
	[FieldOffset(Offset = "0x1C")]
	public float AirResistance;

	[Token(Token = "0x401952F")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve AirResistanceCurve;

	[Token(Token = "0x4019530")]
	[FieldOffset(Offset = "0x24")]
	public float StringRad;

	[Token(Token = "0x4019531")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve StringRadCurve;

	[Token(Token = "0x4019532")]
	[FieldOffset(Offset = "0x2C")]
	public float StringGravity;

	[Token(Token = "0x4019533")]
	[FieldOffset(Offset = "0x30")]
	public List<float> NodeGravity;

	[Token(Token = "0x4019534")]
	[FieldOffset(Offset = "0x34")]
	public List<string> ExcludeTrans;

	[Token(Token = "0x4019535")]
	[FieldOffset(Offset = "0x38")]
	public HangString.FREEZE_AXIS FreezeAxis;

	[Token(Token = "0x4019536")]
	[FieldOffset(Offset = "0x3C")]
	public float FarClipCalcDist;

	[Token(Token = "0x4019537")]
	[FieldOffset(Offset = "0x40")]
	public List<HangColliderSphereProperty> HangCollider_SphereList;

	[Token(Token = "0x4019538")]
	[FieldOffset(Offset = "0x44")]
	public List<HangColliderCapsuleProperty> HangCollider_CapsuleList;

	[Token(Token = "0x4019539")]
	[FieldOffset(Offset = "0x48")]
	public List<HangColliderPlaneProperty> HangCollider_PlaneList;

	[Token(Token = "0x401953A")]
	[FieldOffset(Offset = "0x4C")]
	public bool DBG_AngleLimitDisp;

	[Token(Token = "0x401953B")]
	[FieldOffset(Offset = "0x50")]
	public List<ANGLELIMIT_PROPERTY> AngleLimit;

	[Token(Token = "0x401953C")]
	[FieldOffset(Offset = "0x54")]
	public float FirstBoneRotZOffset;

	[Token(Token = "0x6017A8F")]
	[Address(RVA = "0x3517CE0", Offset = "0x3517CE0", VA = "0x3517CE0")]
	public HangStringProperty()
	{
	}
}
