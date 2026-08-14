using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20007B9")]
public class InWaterDelegator : StatedTaggedTriggerDelegator
{
	[Token(Token = "0x600312E")]
	[Address(RVA = "0x2C77B60", Offset = "0x2C77B60", VA = "0x2C77B60")]
	public InWaterDelegator()
	{
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0x2C77B68", Offset = "0x2C77B68", VA = "0x2C77B68", Slot = "4")]
	protected override bool CheckCollider(Collider other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0x2C77C7C", Offset = "0x2C77C7C", VA = "0x2C77C7C")]
	public bool _003C_003EiFixBaseProxy_CheckCollider(Collider P0)
	{
		return default(bool);
	}
}
