using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200218B")]
public class UILinkActivityPVERankItem : MonoBehaviour
{
	[Token(Token = "0x400D25B")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Rank;

	[Token(Token = "0x400D25C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_PlayerName;

	[Token(Token = "0x400D25D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_EPCount;

	[Token(Token = "0x600B1FC")]
	[Address(RVA = "0x2557F78", Offset = "0x2557F78", VA = "0x2557F78")]
	public UILinkActivityPVERankItem()
	{
	}

	[Token(Token = "0x600B1FD")]
	[Address(RVA = "0x25573FC", Offset = "0x25573FC", VA = "0x25573FC")]
	public void UpdateInfo(string rank, string name, uint epCount)
	{
	}

	[Token(Token = "0x600B1FE")]
	[Address(RVA = "0x2557F80", Offset = "0x2557F80", VA = "0x2557F80")]
	public void Show()
	{
	}

	[Token(Token = "0x600B1FF")]
	[Address(RVA = "0x2557340", Offset = "0x2557340", VA = "0x2557340")]
	public void Hide()
	{
	}
}
