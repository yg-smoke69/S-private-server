using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20007BA")]
public class InWaterOrShoalDelegator : StatedTaggedTriggerDelegator
{
	[Token(Token = "0x6003131")]
	[Address(RVA = "0x2C77C84", Offset = "0x2C77C84", VA = "0x2C77C84")]
	public InWaterOrShoalDelegator()
	{
	}

	[Token(Token = "0x6003132")]
	[Address(RVA = "0x2C77C8C", Offset = "0x2C77C8C", VA = "0x2C77C8C", Slot = "4")]
	protected override bool CheckCollider(Collider other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003133")]
	[Address(RVA = "0x2C77DDC", Offset = "0x2C77DDC", VA = "0x2C77DDC")]
	public bool _003C_003EiFixBaseProxy_CheckCollider(Collider P0)
	{
		return default(bool);
	}
}
