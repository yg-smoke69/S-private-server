using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200276E")]
internal class UIHudGrenadeHintController : UIBaseController
{
	[Token(Token = "0x200276F")]
	public enum HintType
	{
		[Token(Token = "0x400F386")]
		GrenaeHint,
		[Token(Token = "0x400F387")]
		LandmineHint,
		[Token(Token = "0x400F388")]
		FlashHint
	}

	[Token(Token = "0x2002770")]
	private class GrenadeLocationData
	{
		[Token(Token = "0x400F389")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 location;

		[Token(Token = "0x400F38A")]
		[FieldOffset(Offset = "0x14")]
		public HintType hint;

		[Token(Token = "0x600F163")]
		[Address(RVA = "0x133824C", Offset = "0x133824C", VA = "0x133824C")]
		public GrenadeLocationData()
		{
		}
	}

	[Token(Token = "0x400F37F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGrenadeHintView m_View;

	[Token(Token = "0x400F380")]
	[FieldOffset(Offset = "0x2C")]
	private List<GrenadeLocationData> m_GrenadeLocationData;

	[Token(Token = "0x400F381")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float WARNING_RATIO;

	[Token(Token = "0x400F382")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudGrenadeSubHintController> m_hintlist;

	[Token(Token = "0x400F383")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int POOLCOUNT;

	[Token(Token = "0x400F384")]
	[FieldOffset(Offset = "0x34")]
	private List<IHAAMHPPLMG> m_TriggerGrenadedPlayers;

	[Token(Token = "0x600F153")]
	[Address(RVA = "0x1336608", Offset = "0x1336608", VA = "0x1336608")]
	public UIHudGrenadeHintController()
	{
	}

	[Token(Token = "0x600F154")]
	[Address(RVA = "0x1336728", Offset = "0x1336728", VA = "0x1336728")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F155")]
	[Address(RVA = "0x13367CC", Offset = "0x13367CC", VA = "0x13367CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F156")]
	[Address(RVA = "0x1336A80", Offset = "0x1336A80", VA = "0x1336A80", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F157")]
	[Address(RVA = "0x1336BB4", Offset = "0x1336BB4", VA = "0x1336BB4")]
	private void OnOtherTrigger(object[] param)
	{
	}

	[Token(Token = "0x600F158")]
	[Address(RVA = "0x1336E28", Offset = "0x1336E28", VA = "0x1336E28", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F159")]
	[Address(RVA = "0x1336E94", Offset = "0x1336E94", VA = "0x1336E94")]
	private void ClearAllHints()
	{
	}

	[Token(Token = "0x600F15A")]
	[Address(RVA = "0x13370AC", Offset = "0x13370AC", VA = "0x13370AC")]
	private void RefreshGrenadeLocations()
	{
	}

	[Token(Token = "0x600F15B")]
	[Address(RVA = "0x1338744", Offset = "0x1338744", VA = "0x1338744")]
	private bool IsInLandmineRange(LevelLandmine landmine)
	{
		return default(bool);
	}

	[Token(Token = "0x600F15C")]
	[Address(RVA = "0x1338254", Offset = "0x1338254", VA = "0x1338254")]
	private bool ShouldShowHint(Player val)
	{
		return default(bool);
	}

	[Token(Token = "0x600F15D")]
	[Address(RVA = "0x1337B98", Offset = "0x1337B98", VA = "0x1337B98")]
	private bool ShouldShowHint(BaseLevelObject val)
	{
		return default(bool);
	}

	[Token(Token = "0x600F15E")]
	[Address(RVA = "0x13389CC", Offset = "0x13389CC", VA = "0x13389CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600F160")]
	[Address(RVA = "0x1339344", Offset = "0x1339344", VA = "0x1339344")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F161")]
	[Address(RVA = "0x133934C", Offset = "0x133934C", VA = "0x133934C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F162")]
	[Address(RVA = "0x1339354", Offset = "0x1339354", VA = "0x1339354")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
