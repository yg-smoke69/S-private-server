using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CDC")]
public class QuickChatView : MonoBehaviour
{
	[Token(Token = "0x40111D3")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_IndexInTeam;

	[Token(Token = "0x40111D4")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_Message;

	[Token(Token = "0x40111D5")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_IndexBG;

	[Token(Token = "0x6012C61")]
	[Address(RVA = "0x196CF20", Offset = "0x196CF20", VA = "0x196CF20")]
	public QuickChatView()
	{
	}

	[Token(Token = "0x6012C62")]
	[Address(RVA = "0x196CF28", Offset = "0x196CF28", VA = "0x196CF28")]
	public void SetUIData(int index, string message)
	{
	}
}
