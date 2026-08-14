using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002739")]
public class UIHudEnergyStoneMarkController : UIHudNameBaseController
{
	[Token(Token = "0x200273A")]
	private sealed class _003CShowScoreChange_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F21C")]
		[FieldOffset(Offset = "0x8")]
		internal EnergyStoneMarkScore score;

		[Token(Token = "0x400F21D")]
		[FieldOffset(Offset = "0xC")]
		internal List<EnergyStoneMarkScore> socreList;

		[Token(Token = "0x600EF31")]
		[Address(RVA = "0x1CE5744", Offset = "0x1CE5744", VA = "0x1CE5744")]
		public _003CShowScoreChange_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EF32")]
		[Address(RVA = "0x1CE579C", Offset = "0x1CE579C", VA = "0x1CE579C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F217")]
	[FieldOffset(Offset = "0x50")]
	private List<EnergyStoneMarkScore> m_ScoreList;

	[Token(Token = "0x400F218")]
	private const uint MYTEAMARROWCOLOR = 1188691967u;

	[Token(Token = "0x400F219")]
	private const uint OPPOTEAMARRORCOLOR = 4065856511u;

	[Token(Token = "0x400F21A")]
	[FieldOffset(Offset = "0x54")]
	private UIHudEnergyStoneMarkView m_View;

	[Token(Token = "0x400F21B")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_BindPlayerID;

	[Token(Token = "0x600EF1B")]
	[Address(RVA = "0x1CE40E8", Offset = "0x1CE40E8", VA = "0x1CE40E8")]
	public UIHudEnergyStoneMarkController()
	{
	}

	[Token(Token = "0x600EF1C")]
	[Address(RVA = "0x1CE4174", Offset = "0x1CE4174", VA = "0x1CE4174")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF1D")]
	[Address(RVA = "0x1CE421C", Offset = "0x1CE421C", VA = "0x1CE421C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF1E")]
	[Address(RVA = "0x1CE4420", Offset = "0x1CE4420", VA = "0x1CE4420")]
	public void BindPlayer(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600EF1F")]
	[Address(RVA = "0x1CE4608", Offset = "0x1CE4608", VA = "0x1CE4608")]
	private bool IsSameOrLeftTeam(IHAAMHPPLMG pID)
	{
		return default(bool);
	}

	[Token(Token = "0x600EF20")]
	[Address(RVA = "0x1CE484C", Offset = "0x1CE484C", VA = "0x1CE484C")]
	private void SetArrowColor(Color color)
	{
	}

	[Token(Token = "0x600EF21")]
	[Address(RVA = "0x1CE49EC", Offset = "0x1CE49EC", VA = "0x1CE49EC", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF22")]
	[Address(RVA = "0x1CE4B18", Offset = "0x1CE4B18", VA = "0x1CE4B18", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF23")]
	[Address(RVA = "0x1CE4B70", Offset = "0x1CE4B70", VA = "0x1CE4B70", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF24")]
	[Address(RVA = "0x1CE4BC8", Offset = "0x1CE4BC8", VA = "0x1CE4BC8", Slot = "37")]
	protected override bool NeedShowOutScreenAllow()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF25")]
	[Address(RVA = "0x1CE4CF4", Offset = "0x1CE4CF4", VA = "0x1CE4CF4", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF26")]
	[Address(RVA = "0x1CE5078", Offset = "0x1CE5078", VA = "0x1CE5078")]
	private Vector3 GetRefPos(Player p)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF27")]
	[Address(RVA = "0x1CE5118", Offset = "0x1CE5118", VA = "0x1CE5118", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600EF28")]
	[Address(RVA = "0x1CE51A0", Offset = "0x1CE51A0", VA = "0x1CE51A0")]
	private void OnPlayerScoreChange(object[] param)
	{
	}

	[Token(Token = "0x600EF29")]
	[Address(RVA = "0x1CE52D8", Offset = "0x1CE52D8", VA = "0x1CE52D8")]
	private void ShowScoreChange(int scoreValue, byte scoreRegion, bool isLeftTeam)
	{
	}

	[Token(Token = "0x600EF2A")]
	[Address(RVA = "0x1CE574C", Offset = "0x1CE574C", VA = "0x1CE574C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF2B")]
	[Address(RVA = "0x1CE5754", Offset = "0x1CE5754", VA = "0x1CE5754")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF2C")]
	[Address(RVA = "0x1CE575C", Offset = "0x1CE575C", VA = "0x1CE575C")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF2D")]
	[Address(RVA = "0x1CE5764", Offset = "0x1CE5764", VA = "0x1CE5764")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF2E")]
	[Address(RVA = "0x1CE576C", Offset = "0x1CE576C", VA = "0x1CE576C")]
	public bool _003C_003EiFixBaseProxy_NeedShowOutScreenAllow()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF2F")]
	[Address(RVA = "0x1CE5774", Offset = "0x1CE5774", VA = "0x1CE5774")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF30")]
	[Address(RVA = "0x1CE5788", Offset = "0x1CE5788", VA = "0x1CE5788")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
