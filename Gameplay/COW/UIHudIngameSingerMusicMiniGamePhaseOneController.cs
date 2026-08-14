using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200239E")]
public class UIHudIngameSingerMusicMiniGamePhaseOneController : UIBaseController
{
	[Token(Token = "0x400DDDB")]
	[FieldOffset(Offset = "0x28")]
	private UIHudIngameSingerMusicMiniGamePhaseOneView m_view;

	[Token(Token = "0x400DDDC")]
	[FieldOffset(Offset = "0x2C")]
	private MusicMiniGamePhaseOneGameData m_data;

	[Token(Token = "0x400DDDD")]
	[FieldOffset(Offset = "0x30")]
	private List<SingerMiniMusicGamePhaseOneConfigData> toneConfigList;

	[Token(Token = "0x400DDDE")]
	[FieldOffset(Offset = "0x34")]
	private bool hasStart;

	[Token(Token = "0x400DDDF")]
	[FieldOffset(Offset = "0x35")]
	private bool isShow;

	[Token(Token = "0x400DDE0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<SingerMiniMusicGamePhaseOneConfigData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C817")]
	[Address(RVA = "0x22A5D0C", Offset = "0x22A5D0C", VA = "0x22A5D0C")]
	public UIHudIngameSingerMusicMiniGamePhaseOneController()
	{
	}

	[Token(Token = "0x600C818")]
	[Address(RVA = "0x22A5DCC", Offset = "0x22A5DCC", VA = "0x22A5DCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C819")]
	[Address(RVA = "0x22A5E74", Offset = "0x22A5E74", VA = "0x22A5E74")]
	public void MusicGameBegin()
	{
	}

	[Token(Token = "0x600C81A")]
	[Address(RVA = "0x22A604C", Offset = "0x22A604C", VA = "0x22A604C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C81B")]
	[Address(RVA = "0x22A62D8", Offset = "0x22A62D8", VA = "0x22A62D8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C81C")]
	[Address(RVA = "0x22A6474", Offset = "0x22A6474", VA = "0x22A6474", Slot = "23")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600C81D")]
	[Address(RVA = "0x22A64CC", Offset = "0x22A64CC", VA = "0x22A64CC", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600C81E")]
	[Address(RVA = "0x22A6570", Offset = "0x22A6570", VA = "0x22A6570", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C81F")]
	[Address(RVA = "0x22A6630", Offset = "0x22A6630", VA = "0x22A6630")]
	private void Update()
	{
	}

	[Token(Token = "0x600C820")]
	[Address(RVA = "0x22A66CC", Offset = "0x22A66CC", VA = "0x22A66CC")]
	private void CheckToneShow()
	{
	}

	[Token(Token = "0x600C821")]
	[Address(RVA = "0x22A68B8", Offset = "0x22A68B8", VA = "0x22A68B8")]
	private void ShowTone(SingerMiniMusicGamePhaseOneConfigData conf)
	{
	}

	[Token(Token = "0x600C822")]
	[Address(RVA = "0x22A6A08", Offset = "0x22A6A08", VA = "0x22A6A08")]
	private void OnToneFinish(object[] data)
	{
	}

	[Token(Token = "0x600C823")]
	[Address(RVA = "0x22A6DB4", Offset = "0x22A6DB4", VA = "0x22A6DB4")]
	private void OnShowClickEffect(object[] data)
	{
	}

	[Token(Token = "0x600C824")]
	[Address(RVA = "0x22A70F8", Offset = "0x22A70F8", VA = "0x22A70F8")]
	private static int _003CMusicGameBegin_003Em__0(SingerMiniMusicGamePhaseOneConfigData a, SingerMiniMusicGamePhaseOneConfigData b)
	{
		return default(int);
	}

	[Token(Token = "0x600C825")]
	[Address(RVA = "0x22A714C", Offset = "0x22A714C", VA = "0x22A714C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C826")]
	[Address(RVA = "0x22A7154", Offset = "0x22A7154", VA = "0x22A7154")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C827")]
	[Address(RVA = "0x22A715C", Offset = "0x22A715C", VA = "0x22A715C")]
	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600C828")]
	[Address(RVA = "0x22A7164", Offset = "0x22A7164", VA = "0x22A7164")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}

	[Token(Token = "0x600C829")]
	[Address(RVA = "0x22A716C", Offset = "0x22A716C", VA = "0x22A716C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
