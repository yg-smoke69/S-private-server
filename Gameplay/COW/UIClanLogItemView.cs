using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D4A")]
public class UIClanLogItemView : MonoBehaviour
{
	[Token(Token = "0x40115F2")]
	[FieldOffset(Offset = "0xC")]
	private UILabel m_ContentLabel;

	[Token(Token = "0x40115F3")]
	[FieldOffset(Offset = "0x10")]
	private UILabel m_TimeLabel;

	[Token(Token = "0x6012F51")]
	[Address(RVA = "0x2B338DC", Offset = "0x2B338DC", VA = "0x2B338DC")]
	public UIClanLogItemView()
	{
	}

	[Token(Token = "0x6012F52")]
	[Address(RVA = "0x2B3380C", Offset = "0x2B3380C", VA = "0x2B3380C")]
	public void SetData(string content, string time)
	{
	}

	[Token(Token = "0x6012F53")]
	[Address(RVA = "0x2B3376C", Offset = "0x2B3376C", VA = "0x2B3376C")]
	public void Clear()
	{
	}
}
