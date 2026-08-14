using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20007B8")]
public class InRoomDelegator : StatedTaggedTriggerDelegator
{
	[Token(Token = "0x600312B")]
	[Address(RVA = "0x2C77A3C", Offset = "0x2C77A3C", VA = "0x2C77A3C")]
	public InRoomDelegator()
	{
	}

	[Token(Token = "0x600312C")]
	[Address(RVA = "0x2C77A44", Offset = "0x2C77A44", VA = "0x2C77A44", Slot = "4")]
	protected override bool CheckCollider(Collider other)
	{
		return default(bool);
	}

	[Token(Token = "0x600312D")]
	[Address(RVA = "0x2C77B58", Offset = "0x2C77B58", VA = "0x2C77B58")]
	public bool _003C_003EiFixBaseProxy_CheckCollider(Collider P0)
	{
		return default(bool);
	}
}
