using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B61")]
public class HangCollider_Capsule : HangCollider
{
	[Token(Token = "0x40194B6")]
	[FieldOffset(Offset = "0x10")]
	public float ColliCapsuleRadius;

	[Token(Token = "0x40194B7")]
	[FieldOffset(Offset = "0x14")]
	public float ColliCapsuleHeight;

	[Token(Token = "0x6017A44")]
	[Address(RVA = "0x350DB2C", Offset = "0x350DB2C", VA = "0x350DB2C")]
	public HangCollider_Capsule()
	{
	}

	[Token(Token = "0x6017A45")]
	[Address(RVA = "0x350DB4C", Offset = "0x350DB4C", VA = "0x350DB4C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6017A46")]
	[Address(RVA = "0x350DBFC", Offset = "0x350DBFC", VA = "0x350DBFC")]
	public void Collider_Capsule(ref Vector3 Pos, float Rad)
	{
	}

	[Token(Token = "0x6017A47")]
	[Address(RVA = "0x350E570", Offset = "0x350E570", VA = "0x350E570", Slot = "4")]
	public override HangColliderType GetColliderType()
	{
		return default(HangColliderType);
	}
}
