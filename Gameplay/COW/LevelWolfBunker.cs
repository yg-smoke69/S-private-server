using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200073F")]
public class LevelWolfBunker : BaseLevelObject
{
	[Token(Token = "0x4004CC3")]
	[FieldOffset(Offset = "0x74")]
	public GameObject wolfHighlight;

	[Token(Token = "0x4004CC4")]
	[FieldOffset(Offset = "0x78")]
	public GameObject highlight;

	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0xEC0418", Offset = "0xEC0418", VA = "0xEC0418")]
	public LevelWolfBunker()
	{
	}

	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0xEC0420", Offset = "0xEC0420", VA = "0xEC0420", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0xEC04C4", Offset = "0xEC04C4", VA = "0xEC04C4", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002DC9")]
	[Address(RVA = "0xEC0664", Offset = "0xEC0664", VA = "0xEC0664", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0xEC0798", Offset = "0xEC0798", VA = "0xEC0798")]
	private void OnRoleChange(object[] data)
	{
	}

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0xEC0934", Offset = "0xEC0934", VA = "0xEC0934")]
	public void OnLocalPlayerEnter()
	{
	}

	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0xEC0AD8", Offset = "0xEC0AD8", VA = "0xEC0AD8")]
	public void OnLocalPlayerExit()
	{
	}

	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0xEC0C7C", Offset = "0xEC0C7C", VA = "0xEC0C7C")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0xEC0C84", Offset = "0xEC0C84", VA = "0xEC0C84")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
