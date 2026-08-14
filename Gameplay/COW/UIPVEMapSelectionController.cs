using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C3")]
internal class UIPVEMapSelectionController : UIBaseController, _Attribute
{
	[Token(Token = "0x20022C4")]
	private sealed class _003CCloseDifficultyPanel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D94B")]
		[FieldOffset(Offset = "0x8")]
		internal float seconds;

		[Token(Token = "0x400D94C")]
		[FieldOffset(Offset = "0xC")]
		internal UIPVEMapSelectionController _0024this;

		[Token(Token = "0x400D94D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400D94E")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400D94F")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x1700109C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BF68")]
			[Address(RVA = "0x15A9448", Offset = "0x15A9448", VA = "0x15A9448", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700109D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BF69")]
			[Address(RVA = "0x15A9450", Offset = "0x15A9450", VA = "0x15A9450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BF66")]
		[Address(RVA = "0x15A8B4C", Offset = "0x15A8B4C", VA = "0x15A8B4C")]
		public _003CCloseDifficultyPanel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BF67")]
		[Address(RVA = "0x15A92EC", Offset = "0x15A92EC", VA = "0x15A92EC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BF6A")]
		[Address(RVA = "0x15A9458", Offset = "0x15A9458", VA = "0x15A9458", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BF6B")]
		[Address(RVA = "0x15A946C", Offset = "0x15A946C", VA = "0x15A946C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D945")]
	[FieldOffset(Offset = "0x28")]
	private UIPVEMapSelectionView m_View;

	[Token(Token = "0x400D946")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400D947")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400D948")]
	[FieldOffset(Offset = "0x34")]
	private EMapDifficulty m_SelectedDifficulty;

	[Token(Token = "0x400D949")]
	[FieldOffset(Offset = "0x38")]
	private MapConfigData m_MapConfigData;

	[Token(Token = "0x400D94A")]
	[FieldOffset(Offset = "0x3C")]
	private List<int> m_DifficultyOptions;

	[Token(Token = "0x600BF54")]
	[Address(RVA = "0x15A74DC", Offset = "0x15A74DC", VA = "0x15A74DC")]
	public UIPVEMapSelectionController()
	{
	}

	[Token(Token = "0x600BF55")]
	[Address(RVA = "0x15A7594", Offset = "0x15A7594", VA = "0x15A7594")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF56")]
	[Address(RVA = "0x15A763C", Offset = "0x15A763C", VA = "0x15A763C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF57")]
	[Address(RVA = "0x15A8068", Offset = "0x15A8068", VA = "0x15A8068", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF58")]
	[Address(RVA = "0x15A7C14", Offset = "0x15A7C14", VA = "0x15A7C14")]
	private void RefreshMapSprite()
	{
	}

	[Token(Token = "0x600BF59")]
	[Address(RVA = "0x15A81C0", Offset = "0x15A81C0", VA = "0x15A81C0")]
	private void OnDifficultyBtnClick()
	{
	}

	[Token(Token = "0x600BF5A")]
	[Address(RVA = "0x15A7DB4", Offset = "0x15A7DB4", VA = "0x15A7DB4")]
	private void ChangeMapDifficutly(EMapDifficulty difficulty)
	{
	}

	[Token(Token = "0x600BF5B")]
	[Address(RVA = "0x15A8A50", Offset = "0x15A8A50", VA = "0x15A8A50")]
	private IEnumerator CloseDifficultyPanel(float seconds)
	{
		return null;
	}

	[Token(Token = "0x600BF5C")]
	[Address(RVA = "0x15A8B54", Offset = "0x15A8B54", VA = "0x15A8B54")]
	private void RefreshDifficultyBtnStatus()
	{
	}

	[Token(Token = "0x600BF5D")]
	[Address(RVA = "0x15A8D14", Offset = "0x15A8D14", VA = "0x15A8D14")]
	public void SetMapData()
	{
	}

	[Token(Token = "0x600BF5E")]
	[Address(RVA = "0x15A884C", Offset = "0x15A884C", VA = "0x15A884C")]
	private void SetArrRotation()
	{
	}

	[Token(Token = "0x600BF5F")]
	[Address(RVA = "0x15A8D7C", Offset = "0x15A8D7C", VA = "0x15A8D7C")]
	private void OnBtn1Click()
	{
	}

	[Token(Token = "0x600BF60")]
	[Address(RVA = "0x15A8E4C", Offset = "0x15A8E4C", VA = "0x15A8E4C")]
	private void OnBtn2Click()
	{
	}

	[Token(Token = "0x600BF61")]
	[Address(RVA = "0x15A8F1C", Offset = "0x15A8F1C", VA = "0x15A8F1C")]
	private void CloseMapSelectionPanel(object[] data)
	{
	}

	[Token(Token = "0x600BF62")]
	[Address(RVA = "0x15A9158", Offset = "0x15A9158", VA = "0x15A9158", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BF63")]
	[Address(RVA = "0x15A9224", Offset = "0x15A9224", VA = "0x15A9224", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BF64")]
	[Address(RVA = "0x15A92DC", Offset = "0x15A92DC", VA = "0x15A92DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF65")]
	[Address(RVA = "0x15A92E4", Offset = "0x15A92E4", VA = "0x15A92E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
