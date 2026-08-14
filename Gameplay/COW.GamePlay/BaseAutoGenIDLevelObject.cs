using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x20005A9")]
public class BaseAutoGenIDLevelObject : BaseLevelObject
{
	[Token(Token = "0x6002271")]
	[Address(RVA = "0x13B2C1C", Offset = "0x13B2C1C", VA = "0x13B2C1C")]
	public BaseAutoGenIDLevelObject()
	{
	}

	[Token(Token = "0x6002272")]
	[Address(RVA = "0x13B2D68", Offset = "0x13B2D68", VA = "0x13B2D68", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002273")]
	[Address(RVA = "0x13B2E40", Offset = "0x13B2E40", VA = "0x13B2E40", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002274")]
	[Address(RVA = "0x13B3094", Offset = "0x13B3094", VA = "0x13B3094", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002275")]
	[Address(RVA = "0x13B32DC", Offset = "0x13B32DC", VA = "0x13B32DC", Slot = "40")]
	public virtual bool NeedRegenIDWhenDelete()
	{
		return default(bool);
	}

	[Token(Token = "0x6002276")]
	[Address(RVA = "0x13B3334", Offset = "0x13B3334", VA = "0x13B3334")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002277")]
	[Address(RVA = "0x13B3338", Offset = "0x13B3338", VA = "0x13B3338")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
