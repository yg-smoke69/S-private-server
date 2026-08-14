using System.Collections.Generic;
using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C30")]
public class TBTTreeNode
{
	[Token(Token = "0x4019A13")]
	private const int defaultChildCount = -1;

	[Token(Token = "0x4019A14")]
	[FieldOffset(Offset = "0x8")]
	private List<TBTTreeNode> _children;

	[Token(Token = "0x4019A15")]
	[FieldOffset(Offset = "0xC")]
	private int _maxChildCount;

	[Token(Token = "0x601804B")]
	[Address(RVA = "0x263F678", Offset = "0x263F678", VA = "0x263F678")]
	public TBTTreeNode(int maxChildCount = -1)
	{
	}

	[Token(Token = "0x601804C")]
	[Address(RVA = "0x26416F4", Offset = "0x26416F4", VA = "0x26416F4")]
	public TBTTreeNode()
	{
	}

	[Token(Token = "0x601804D")]
	[Address(RVA = "0x263F8A0", Offset = "0x263F8A0", VA = "0x263F8A0", Slot = "1")]
	~TBTTreeNode()
	{
	}

	[Token(Token = "0x601804E")]
	[Address(RVA = "0x26412D8", Offset = "0x26412D8", VA = "0x26412D8")]
	public TBTTreeNode AddChild(TBTTreeNode node)
	{
		return null;
	}

	[Token(Token = "0x601804F")]
	[Address(RVA = "0x2640618", Offset = "0x2640618", VA = "0x2640618")]
	public int GetChildCount()
	{
		return default(int);
	}

	[Token(Token = "0x6018050")]
	[Address(RVA = "0x263FDE4", Offset = "0x263FDE4", VA = "0x263FDE4")]
	public bool IsIndexValid(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6018051")]
	public T GetChild<T>(int index) where T : TBTTreeNode
	{
		return null;
	}
}
