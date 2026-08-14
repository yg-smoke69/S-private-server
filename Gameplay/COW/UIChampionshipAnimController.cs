using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001FF3")]
public class UIChampionshipAnimController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2001FF4")]
	private abstract class ChampionshipAnimBase : _Attribute
	{
		[Token(Token = "0x400C8E2")]
		[FieldOffset(Offset = "0x8")]
		public string m_AnimTrigger;

		[Token(Token = "0x400C8E3")]
		[FieldOffset(Offset = "0xC")]
		public uint m_NotifyFlag;

		[Token(Token = "0x400C8E4")]
		[FieldOffset(Offset = "0x10")]
		protected uint m_SortIndex;

		[Token(Token = "0x400C8E5")]
		[FieldOffset(Offset = "0x14")]
		protected UIChampionshipAnimController m_Ctrl;

		[Token(Token = "0x400C8E6")]
		[FieldOffset(Offset = "0x18")]
		protected uint m_CurrentChampionshipID;

		[Token(Token = "0x400C8E7")]
		[FieldOffset(Offset = "0x1C")]
		protected uint m_ChampionshipType;

		[Token(Token = "0x600A14A")]
		[Address(RVA = "0x145C2F0", Offset = "0x145C2F0", VA = "0x145C2F0")]
		public ChampionshipAnimBase(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		[Token(Token = "0x600A14B")]
		[Address(RVA = "0x145C934", Offset = "0x145C934", VA = "0x145C934", Slot = "5")]
		public virtual void InitAnimInfo()
		{
		}

		[Token(Token = "0x600A14C")]
		[Address(RVA = "0x145C8DC", Offset = "0x145C8DC", VA = "0x145C8DC", Slot = "6")]
		public virtual void SetAnimCSInfo()
		{
		}

		[Token(Token = "0x600A14D")]
		[Address(RVA = "0x145C994", Offset = "0x145C994", VA = "0x145C994", Slot = "4")]
		public int CompareTo(ChampionshipAnimBase other)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001FF5")]
	private class AwardAnim : ChampionshipAnimBase
	{
		[Token(Token = "0x400C8E8")]
		[FieldOffset(Offset = "0x20")]
		private ChampionshipInfo championshipInfo;

		[Token(Token = "0x600A14E")]
		[Address(RVA = "0x145ADE0", Offset = "0x145ADE0", VA = "0x145ADE0")]
		public AwardAnim(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		[Token(Token = "0x600A14F")]
		[Address(RVA = "0x145C3EC", Offset = "0x145C3EC", VA = "0x145C3EC", Slot = "5")]
		public override void InitAnimInfo()
		{
		}

		[Token(Token = "0x600A150")]
		[Address(RVA = "0x145C44C", Offset = "0x145C44C", VA = "0x145C44C")]
		private void RequestData()
		{
		}

		[Token(Token = "0x600A151")]
		[Address(RVA = "0x145C6A0", Offset = "0x145C6A0", VA = "0x145C6A0", Slot = "6")]
		public override void SetAnimCSInfo()
		{
		}

		[Token(Token = "0x600A152")]
		[Address(RVA = "0x145C930", Offset = "0x145C930", VA = "0x145C930")]
		public void _003C_003EiFixBaseProxy_InitAnimInfo()
		{
		}

		[Token(Token = "0x600A153")]
		[Address(RVA = "0x145C988", Offset = "0x145C988", VA = "0x145C988")]
		public void _003C_003EiFixBaseProxy_SetAnimCSInfo()
		{
		}
	}

	[Token(Token = "0x2001FF6")]
	private class AwardAnimNoPos : AwardAnim
	{
		[Token(Token = "0x600A154")]
		[Address(RVA = "0x145AE60", Offset = "0x145AE60", VA = "0x145AE60")]
		public AwardAnimNoPos(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}
	}

	[Token(Token = "0x2001FF7")]
	private class SeasonAnim : ChampionshipAnimBase
	{
		[Token(Token = "0x600A155")]
		[Address(RVA = "0x145AD60", Offset = "0x145AD60", VA = "0x145AD60")]
		public SeasonAnim(UIChampionshipAnimController ctrl, uint championshipType)
		{
		}

		[Token(Token = "0x600A156")]
		[Address(RVA = "0x145CA18", Offset = "0x145CA18", VA = "0x145CA18", Slot = "6")]
		public override void SetAnimCSInfo()
		{
		}

		[Token(Token = "0x600A157")]
		[Address(RVA = "0x145CBB8", Offset = "0x145CBB8", VA = "0x145CBB8")]
		public void _003C_003EiFixBaseProxy_SetAnimCSInfo()
		{
		}
	}

	[Token(Token = "0x2001FF8")]
	public enum CSAnimType
	{
		[Token(Token = "0x400C8EA")]
		Season,
		[Token(Token = "0x400C8EB")]
		Award,
		[Token(Token = "0x400C8EC")]
		AwardNoPos
	}

	[Token(Token = "0x2001FF9")]
	public class CSAnimInfo
	{
		[Token(Token = "0x400C8ED")]
		[FieldOffset(Offset = "0x8")]
		public CSAnimType m_AnimType;

		[Token(Token = "0x400C8EE")]
		[FieldOffset(Offset = "0xC")]
		public uint m_ChampionshipType;

		[Token(Token = "0x600A158")]
		[Address(RVA = "0x145C98C", Offset = "0x145C98C", VA = "0x145C98C")]
		public CSAnimInfo()
		{
		}
	}

	[Token(Token = "0x400C8DD")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipAnimView m_View;

	[Token(Token = "0x400C8DE")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C8DF")]
	[FieldOffset(Offset = "0x50")]
	private List<ChampionshipAnimBase> m_AnimList;

	[Token(Token = "0x400C8E0")]
	[FieldOffset(Offset = "0x54")]
	private uint m_Flag;

	[Token(Token = "0x400C8E1")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, string> m_CupIconDict;

	[Token(Token = "0x600A135")]
	[Address(RVA = "0x1459EF8", Offset = "0x1459EF8", VA = "0x1459EF8")]
	public UIChampionshipAnimController()
	{
	}

	[Token(Token = "0x600A136")]
	[Address(RVA = "0x145A09C", Offset = "0x145A09C", VA = "0x145A09C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A137")]
	[Address(RVA = "0x145A140", Offset = "0x145A140", VA = "0x145A140", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A138")]
	[Address(RVA = "0x145A3A4", Offset = "0x145A3A4", VA = "0x145A3A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A139")]
	[Address(RVA = "0x145A42C", Offset = "0x145A42C", VA = "0x145A42C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A13A")]
	[Address(RVA = "0x145A544", Offset = "0x145A544", VA = "0x145A544")]
	public void RefreshView(List<CSAnimInfo> m_AnimTypeList)
	{
	}

	[Token(Token = "0x600A13B")]
	[Address(RVA = "0x145A5D4", Offset = "0x145A5D4", VA = "0x145A5D4")]
	private void AnimCreateFactory(List<CSAnimInfo> m_AnimInfoList)
	{
	}

	[Token(Token = "0x600A13C")]
	[Address(RVA = "0x145A950", Offset = "0x145A950", VA = "0x145A950")]
	private void AnimListInit()
	{
	}

	[Token(Token = "0x600A13D")]
	[Address(RVA = "0x145AB74", Offset = "0x145AB74", VA = "0x145AB74")]
	private bool PlayAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600A13E")]
	[Address(RVA = "0x145AED8", Offset = "0x145AED8", VA = "0x145AED8")]
	public void SetSeasonInfo(uint championshipID, uint championshipType)
	{
	}

	[Token(Token = "0x600A13F")]
	[Address(RVA = "0x145B2D4", Offset = "0x145B2D4", VA = "0x145B2D4")]
	public void SetAwardInfo(uint championshipID, uint championshipType)
	{
	}

	[Token(Token = "0x600A140")]
	[Address(RVA = "0x145B9CC", Offset = "0x145B9CC", VA = "0x145B9CC")]
	private void SetRankNum(AccountChampionshipInfo accountInfo, uint localSize)
	{
	}

	[Token(Token = "0x600A141")]
	[Address(RVA = "0x145BCF0", Offset = "0x145BCF0", VA = "0x145BCF0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A142")]
	[Address(RVA = "0x145BD9C", Offset = "0x145BD9C", VA = "0x145BD9C")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600A143")]
	[Address(RVA = "0x145BE10", Offset = "0x145BE10", VA = "0x145BE10")]
	private void OnGotoMailBtnClick()
	{
	}

	[Token(Token = "0x600A144")]
	[Address(RVA = "0x145BF9C", Offset = "0x145BF9C", VA = "0x145BF9C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A145")]
	[Address(RVA = "0x145C23C", Offset = "0x145C23C", VA = "0x145C23C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A146")]
	[Address(RVA = "0x145C2D0", Offset = "0x145C2D0", VA = "0x145C2D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A147")]
	[Address(RVA = "0x145C2D8", Offset = "0x145C2D8", VA = "0x145C2D8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A148")]
	[Address(RVA = "0x145C2E0", Offset = "0x145C2E0", VA = "0x145C2E0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600A149")]
	[Address(RVA = "0x145C2E8", Offset = "0x145C2E8", VA = "0x145C2E8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
