using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002265")]
internal class UIMatchResultProfileInfoController : UIBaseController
{
	[Token(Token = "0x400D717")]
	[FieldOffset(Offset = "0x28")]
	private UIMatchResultProfileInfoView m_View;

	[Token(Token = "0x400D718")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCall;

	[Token(Token = "0x400D719")]
	[FieldOffset(Offset = "0x30")]
	private List<uint> m_battleTags;

	[Token(Token = "0x400D71A")]
	[FieldOffset(Offset = "0x34")]
	private int count;

	[Token(Token = "0x400D71B")]
	[FieldOffset(Offset = "0x38")]
	private float m_showTimeStamp;

	[Token(Token = "0x400D71C")]
	[FieldOffset(Offset = "0x3C")]
	private float m_showTimeInterval;

	[Token(Token = "0x400D71D")]
	[FieldOffset(Offset = "0x40")]
	private string moveAnim;

	[Token(Token = "0x400D71E")]
	[FieldOffset(Offset = "0x44")]
	private UIProfileTagSmallController ctrl;

	[Token(Token = "0x400D71F")]
	[FieldOffset(Offset = "0x48")]
	private int index;

	[Token(Token = "0x400D720")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_ActiveAnim;

	[Token(Token = "0x600BBDF")]
	[Address(RVA = "0x2817D84", Offset = "0x2817D84", VA = "0x2817D84")]
	public UIMatchResultProfileInfoController()
	{
	}

	[Token(Token = "0x600BBE0")]
	[Address(RVA = "0x2817E68", Offset = "0x2817E68", VA = "0x2817E68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BBE1")]
	[Address(RVA = "0x2817F10", Offset = "0x2817F10", VA = "0x2817F10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BBE2")]
	[Address(RVA = "0x2818108", Offset = "0x2818108", VA = "0x2818108", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BBE3")]
	[Address(RVA = "0x28182B8", Offset = "0x28182B8", VA = "0x28182B8", Slot = "31")]
	public virtual void SetData(UIHudResultShowBaseController.AvatarProfileInfo data)
	{
	}

	[Token(Token = "0x600BBE4")]
	[Address(RVA = "0x2818AA4", Offset = "0x2818AA4", VA = "0x2818AA4")]
	public void ShowMVPFlag(bool isWin)
	{
	}

	[Token(Token = "0x600BBE5")]
	[Address(RVA = "0x2818BAC", Offset = "0x2818BAC", VA = "0x2818BAC")]
	public void SetIsSelf()
	{
	}

	[Token(Token = "0x600BBE6")]
	[Address(RVA = "0x281887C", Offset = "0x281887C", VA = "0x281887C")]
	public void SetBattleTags(List<uint> battleTags)
	{
	}

	[Token(Token = "0x600BBE7")]
	[Address(RVA = "0x28190FC", Offset = "0x28190FC", VA = "0x28190FC")]
	public void Update()
	{
	}

	[Token(Token = "0x600BBE8")]
	[Address(RVA = "0x2818C74", Offset = "0x2818C74", VA = "0x2818C74")]
	private void ShowBattleTagAnim()
	{
	}

	[Token(Token = "0x600BBE9")]
	[Address(RVA = "0x2819168", Offset = "0x2819168", VA = "0x2819168")]
	public void ActiveBattleTagsAnim(object[] param)
	{
	}

	[Token(Token = "0x600BBEA")]
	[Address(RVA = "0x28191DC", Offset = "0x28191DC", VA = "0x28191DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BBEB")]
	[Address(RVA = "0x28191E4", Offset = "0x28191E4", VA = "0x28191E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
