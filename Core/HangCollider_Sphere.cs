using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B63")]
public class HangCollider_Sphere : HangCollider
{
	[Token(Token = "0x40194B8")]
	[FieldOffset(Offset = "0x10")]
	public float ColliSphereRadius;

	[Token(Token = "0x6017A4B")]
	[Address(RVA = "0x350EA44", Offset = "0x350EA44", VA = "0x350EA44")]
	public HangCollider_Sphere()
	{
	}

	[Token(Token = "0x6017A4C")]
	[Address(RVA = "0x350EA54", Offset = "0x350EA54", VA = "0x350EA54")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6017A4D")]
	[Address(RVA = "0x350EAEC", Offset = "0x350EAEC", VA = "0x350EAEC")]
	public void Collider_Sphere(ref Vector3 Pos, float Rad)
	{
	}

	[Token(Token = "0x6017A4E")]
	[Address(RVA = "0x350EC0C", Offset = "0x350EC0C", VA = "0x350EC0C", Slot = "4")]
	public override HangColliderType GetColliderType()
	{
		return default(HangColliderType);
	}
}
