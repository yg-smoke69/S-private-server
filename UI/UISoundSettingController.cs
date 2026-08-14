using System;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002390")]
public class UISoundSettingController : UISettingContentBase
{
	[Token(Token = "0x2002391")]
	private enum SoundSettingKey
	{
		[Token(Token = "0x400DD84")]
		Music,
		[Token(Token = "0x400DD85")]
		SoundEffect,
		[Token(Token = "0x400DD86")]
		KillSoundEffect,
		[Token(Token = "0x400DD87")]
		GameVoice,
		[Token(Token = "0x400DD88")]
		PCFireSound,
		[Token(Token = "0x400DD89")]
		PCAchievementSound,
		[Token(Token = "0x400DD8A")]
		SpecialCharacterVoice
	}

	[Token(Token = "0x400DD76")]
	[FieldOffset(Offset = "0x2C")]
	private UISoundSettingView m_View;

	[Token(Token = "0x400DD77")]
	[FieldOffset(Offset = "0x30")]
	private CommonSettingContentData m_Data;

	[Token(Token = "0x400DD78")]
	[FieldOffset(Offset = "0x34")]
	private UICommonSettingContentController m_Ctrl;

	[Token(Token = "0x400DD79")]
	[FieldOffset(Offset = "0x0")]
	private static Func<float> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400DD7A")]
	[FieldOffset(Offset = "0x4")]
	private static Action<float> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DD7B")]
	[FieldOffset(Offset = "0x8")]
	private static Func<float> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400DD7C")]
	[FieldOffset(Offset = "0xC")]
	private static Action<float> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400DD7D")]
	[FieldOffset(Offset = "0x10")]
	private static Func<float> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x400DD7E")]
	[FieldOffset(Offset = "0x14")]
	private static Action<float> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400DD7F")]
	[FieldOffset(Offset = "0x18")]
	private static Func<float> _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x400DD80")]
	[FieldOffset(Offset = "0x1C")]
	private static Action<float> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400DD81")]
	[FieldOffset(Offset = "0x20")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400DD82")]
	[FieldOffset(Offset = "0x24")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x600C7B0")]
	[Address(RVA = "0x224AA78", Offset = "0x224AA78", VA = "0x224AA78")]
	public UISoundSettingController()
	{
	}

	[Token(Token = "0x600C7B1")]
	[Address(RVA = "0x224AAF0", Offset = "0x224AAF0", VA = "0x224AAF0", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C7B2")]
	[Address(RVA = "0x224ABD0", Offset = "0x224ABD0", VA = "0x224ABD0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C7B3")]
	[Address(RVA = "0x224AC38", Offset = "0x224AC38", VA = "0x224AC38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C7B4")]
	[Address(RVA = "0x224B97C", Offset = "0x224B97C", VA = "0x224B97C")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C7B5")]
	[Address(RVA = "0x224AF3C", Offset = "0x224AF3C", VA = "0x224AF3C")]
	private CommonSettingItemDataSlider CreateMusicData()
	{
		return null;
	}

	[Token(Token = "0x600C7B6")]
	[Address(RVA = "0x224B0FC", Offset = "0x224B0FC", VA = "0x224B0FC")]
	private CommonSettingItemDataSlider CreateSoundEffectData()
	{
		return null;
	}

	[Token(Token = "0x600C7B7")]
	[Address(RVA = "0x224B2B8", Offset = "0x224B2B8", VA = "0x224B2B8")]
	private CommonSettingItemDataSlider CreateKillSoundEffectData()
	{
		return null;
	}

	[Token(Token = "0x600C7B8")]
	[Address(RVA = "0x224B474", Offset = "0x224B474", VA = "0x224B474")]
	private CommonSettingItemDataSlider CreateGameVoiceData()
	{
		return null;
	}

	[Token(Token = "0x600C7B9")]
	[Address(RVA = "0x224B630", Offset = "0x224B630", VA = "0x224B630")]
	private CommonSettingItemDataToggleBtns CreateSpecialCharacterVoiceData()
	{
		return null;
	}

	[Token(Token = "0x600C7BA")]
	[Address(RVA = "0x224B980", Offset = "0x224B980", VA = "0x224B980")]
	public static void OnSpecialCharacterVoiceSwitchClick(bool enable)
	{
	}

	[Token(Token = "0x600C7BB")]
	[Address(RVA = "0x224BA94", Offset = "0x224BA94", VA = "0x224BA94")]
	private int SetSpecialCharacterVoiceSetting()
	{
		return default(int);
	}

	[Token(Token = "0x600C7BC")]
	[Address(RVA = "0x224AB1C", Offset = "0x224AB1C", VA = "0x224AB1C")]
	private void RefreshBtnsState()
	{
	}

	[Token(Token = "0x600C7BD")]
	[Address(RVA = "0x224BB14", Offset = "0x224BB14", VA = "0x224BB14")]
	private static void _003CCreateMusicData_003Em__0(float value)
	{
	}

	[Token(Token = "0x600C7BE")]
	[Address(RVA = "0x224BCE4", Offset = "0x224BCE4", VA = "0x224BCE4")]
	private static void _003CCreateSoundEffectData_003Em__1(float value)
	{
	}

	[Token(Token = "0x600C7BF")]
	[Address(RVA = "0x224BEB4", Offset = "0x224BEB4", VA = "0x224BEB4")]
	private static void _003CCreateKillSoundEffectData_003Em__2(float value)
	{
	}

	[Token(Token = "0x600C7C0")]
	[Address(RVA = "0x224BF38", Offset = "0x224BF38", VA = "0x224BF38")]
	private static void _003CCreateGameVoiceData_003Em__3(float value)
	{
	}

	[Token(Token = "0x600C7C1")]
	[Address(RVA = "0x224C09C", Offset = "0x224C09C", VA = "0x224C09C")]
	private static void _003CCreateSpecialCharacterVoiceData_003Em__4()
	{
	}

	[Token(Token = "0x600C7C2")]
	[Address(RVA = "0x224C0A4", Offset = "0x224C0A4", VA = "0x224C0A4")]
	private static void _003CCreateSpecialCharacterVoiceData_003Em__5()
	{
	}
}
