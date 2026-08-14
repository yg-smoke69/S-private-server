using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001E7D")]
public class ActivityAwardDescription : UIBaseController
{
	[Token(Token = "0x2001E7E")]
	private enum OperateStatus
	{
		[Token(Token = "0x400BFB1")]
		None,
		[Token(Token = "0x400BFB2")]
		GoTo,
		[Token(Token = "0x400BFB3")]
		UnFinished,
		[Token(Token = "0x400BFB4")]
		Available,
		[Token(Token = "0x400BFB5")]
		Received
	}

	[Token(Token = "0x400BFA0")]
	[FieldOffset(Offset = "0x28")]
	public UIButton OperateButton;

	[Token(Token = "0x400BFA1")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite OperateWhite;

	[Token(Token = "0x400BFA2")]
	[FieldOffset(Offset = "0x30")]
	public UISprite OperateGray;

	[Token(Token = "0x400BFA3")]
	[FieldOffset(Offset = "0x34")]
	public UISprite OperateYellow;

	[Token(Token = "0x400BFA4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OperateTitle;

	[Token(Token = "0x400BFA5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Progress;

	[Token(Token = "0x400BFA6")]
	[FieldOffset(Offset = "0x40")]
	public UIScrollView AwardScrollView;

	[Token(Token = "0x400BFA7")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid AwardGrid;

	[Token(Token = "0x400BFA8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OperateGained;

	[Token(Token = "0x400BFA9")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel OperateGainedLabel;

	[Token(Token = "0x400BFAA")]
	[FieldOffset(Offset = "0x50")]
	public Animation ButtonAnimation;

	[Token(Token = "0x400BFAB")]
	[FieldOffset(Offset = "0x54")]
	protected ClientActivityDesc m_Desc;

	[Token(Token = "0x400BFAC")]
	[FieldOffset(Offset = "0x58")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x400BFAD")]
	[FieldOffset(Offset = "0x5C")]
	protected UIModelActivity m_ModelActivity;

	[Token(Token = "0x400BFAE")]
	[FieldOffset(Offset = "0x60")]
	private List<UIStandardItemMiniController> m_CacheAwardList;

	[Token(Token = "0x400BFAF")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AwardDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60092A9")]
	[Address(RVA = "0x14B9448", Offset = "0x14B9448", VA = "0x14B9448")]
	public ActivityAwardDescription()
	{
	}

	[Token(Token = "0x60092AA")]
	[Address(RVA = "0x14B9500", Offset = "0x14B9500", VA = "0x14B9500")]
	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60092AB")]
	[Address(RVA = "0x14B95A8", Offset = "0x14B95A8", VA = "0x14B95A8")]
	protected void Start()
	{
	}

	[Token(Token = "0x60092AC")]
	[Address(RVA = "0x14B96C0", Offset = "0x14B96C0", VA = "0x14B96C0")]
	public void SetData(ClientActivityDesc desc)
	{
	}

	[Token(Token = "0x60092AD")]
	[Address(RVA = "0x14B9F8C", Offset = "0x14B9F8C", VA = "0x14B9F8C", Slot = "31")]
	protected virtual void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x60092AE")]
	[Address(RVA = "0x14B981C", Offset = "0x14B981C", VA = "0x14B981C")]
	private void CreateAwards(List<AwardDesc> awards, bool big_prize)
	{
	}

	[Token(Token = "0x60092AF")]
	[Address(RVA = "0x14BAA54", Offset = "0x14BAA54", VA = "0x14BAA54")]
	private void PlayButtonAnimation()
	{
	}

	[Token(Token = "0x60092B0")]
	[Address(RVA = "0x14BAC80", Offset = "0x14BAC80", VA = "0x14BAC80", Slot = "32")]
	protected virtual void OnOperate()
	{
	}

	[Token(Token = "0x60092B1")]
	[Address(RVA = "0x14BAFEC", Offset = "0x14BAFEC", VA = "0x14BAFEC")]
	public void Reload()
	{
	}

	[Token(Token = "0x60092B2")]
	[Address(RVA = "0x14BB058", Offset = "0x14BB058", VA = "0x14BB058")]
	private static bool _003CCreateAwards_003Em__0(AwardDesc e)
	{
		return default(bool);
	}
}
