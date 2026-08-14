using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D19")]
public class UIHudKillNotificationItem : MonoBehaviour
{
	[Token(Token = "0x4011373")]
	[FieldOffset(Offset = "0xC")]
	public GameObject InfoContainer;

	[Token(Token = "0x4011374")]
	[FieldOffset(Offset = "0x10")]
	public UILabel text;

	[Token(Token = "0x4011375")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_RedEnvelopeGo;

	[Token(Token = "0x4011376")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_NotifyIcon;

	[Token(Token = "0x4011377")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel m_RedEnvelopeLabel;

	[Token(Token = "0x4011378")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_BonusIcon;

	[Token(Token = "0x4011379")]
	[FieldOffset(Offset = "0x24")]
	private Timer m_ShowupTimer;

	[Token(Token = "0x401137A")]
	[FieldOffset(Offset = "0x28")]
	private string m_KillVerbColor;

	[Token(Token = "0x401137B")]
	[FieldOffset(Offset = "0x2C")]
	private StringBuilder m_TextBuilder;

	[Token(Token = "0x17001356")]
	public bool PlainVerbColor
	{
		[Token(Token = "0x6012DA9")]
		[Address(RVA = "0x1BB4C4C", Offset = "0x1BB4C4C", VA = "0x1BB4C4C")]
		set
		{
		}
	}

	[Token(Token = "0x6012DA8")]
	[Address(RVA = "0x1BB8FA8", Offset = "0x1BB8FA8", VA = "0x1BB8FA8")]
	public UIHudKillNotificationItem()
	{
	}

	[Token(Token = "0x6012DAA")]
	[Address(RVA = "0x1BB4D1C", Offset = "0x1BB4D1C", VA = "0x1BB4D1C")]
	public void SetActive(bool v)
	{
	}

	[Token(Token = "0x6012DAB")]
	[Address(RVA = "0x1BB56D8", Offset = "0x1BB56D8", VA = "0x1BB56D8")]
	public bool IsActive(float gameTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6012DAC")]
	[Address(RVA = "0x1BB579C", Offset = "0x1BB579C", VA = "0x1BB579C")]
	public void MoveTo(UIHudKillNotificationItem item)
	{
	}

	[Token(Token = "0x6012DAD")]
	[Address(RVA = "0x1BB9048", Offset = "0x1BB9048", VA = "0x1BB9048", Slot = "4")]
	public virtual void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}
}
