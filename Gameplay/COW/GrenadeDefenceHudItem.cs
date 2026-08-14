using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CE5")]
public class GrenadeDefenceHudItem : EdgeDetectHudItem
{
	[Token(Token = "0x4011214")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Normal;

	[Token(Token = "0x4011215")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SmartIceWall;

	[Token(Token = "0x4011216")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget BG1;

	[Token(Token = "0x4011217")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget BG2;

	[Token(Token = "0x6012C9D")]
	[Address(RVA = "0x120D8FC", Offset = "0x120D8FC", VA = "0x120D8FC")]
	public GrenadeDefenceHudItem()
	{
	}

	[Token(Token = "0x6012C9E")]
	[Address(RVA = "0x120D904", Offset = "0x120D904", VA = "0x120D904", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6012C9F")]
	[Address(RVA = "0x120DA94", Offset = "0x120DA94", VA = "0x120DA94", Slot = "8")]
	public override void EdgeDetect()
	{
	}

	[Token(Token = "0x6012CA0")]
	[Address(RVA = "0x120DB70", Offset = "0x120DB70", VA = "0x120DB70")]
	public new void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x6012CA1")]
	[Address(RVA = "0x120DB78", Offset = "0x120DB78", VA = "0x120DB78")]
	public void _003C_003EiFixBaseProxy_EdgeDetect()
	{
	}
}
