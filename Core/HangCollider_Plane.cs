using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B62")]
public class HangCollider_Plane : HangCollider
{
	[Token(Token = "0x6017A48")]
	[Address(RVA = "0x350E578", Offset = "0x350E578", VA = "0x350E578")]
	public HangCollider_Plane()
	{
	}

	[Token(Token = "0x6017A49")]
	[Address(RVA = "0x350E580", Offset = "0x350E580", VA = "0x350E580")]
	public void Collider_Plane(ref Vector3 Pos, float Rad)
	{
	}

	[Token(Token = "0x6017A4A")]
	[Address(RVA = "0x350EA3C", Offset = "0x350EA3C", VA = "0x350EA3C", Slot = "4")]
	public override HangColliderType GetColliderType()
	{
		return default(HangColliderType);
	}
}
