using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002146")]
public class UIHyperBookContentPageItemController : UIBaseController
{
	[Token(Token = "0x2002147")]
	private sealed class _003CPlayProgressVarValueUpdateCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D0E7")]
		[FieldOffset(Offset = "0x8")]
		internal float value;

		[Token(Token = "0x400D0E8")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Cpass_003E__0;

		[Token(Token = "0x400D0E9")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CbaseValue_003E__0;

		[Token(Token = "0x400D0EA")]
		[FieldOffset(Offset = "0x14")]
		internal float _003CdeltaValue_003E__0;

		[Token(Token = "0x400D0EB")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Cpercent_003E__1;

		[Token(Token = "0x400D0EC")]
		[FieldOffset(Offset = "0x1C")]
		internal UIHyperBookContentPageItemController _0024this;

		[Token(Token = "0x400D0ED")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400D0EE")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400D0EF")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001013")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AF65")]
			[Address(RVA = "0x2959910", Offset = "0x2959910", VA = "0x2959910", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001014")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AF66")]
			[Address(RVA = "0x2959918", Offset = "0x2959918", VA = "0x2959918", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AF63")]
		[Address(RVA = "0x2959218", Offset = "0x2959218", VA = "0x2959218")]
		public _003CPlayProgressVarValueUpdateCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AF64")]
		[Address(RVA = "0x2959788", Offset = "0x2959788", VA = "0x2959788", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AF67")]
		[Address(RVA = "0x2959920", Offset = "0x2959920", VA = "0x2959920", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AF68")]
		[Address(RVA = "0x2959934", Offset = "0x2959934", VA = "0x2959934", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D0D4")]
	private const string COMMON_PAGE_COLLECTION_BG_NAME = "FF_UI_HyperBook_Frame";

	[Token(Token = "0x400D0D5")]
	private const string HIDDEN_PAGE_COLLECTION_BG_NAME = "FF_UI_HyperBook_Frame_Hidden";

	[Token(Token = "0x400D0D6")]
	private const string COMMON_PAGE_LABEL_COLOR_STR = "#A5EFFF";

	[Token(Token = "0x400D0D7")]
	private const string GRAY_PAGE_LABEL_COLOR_STR = "#939393";

	[Token(Token = "0x400D0D8")]
	private const string HIDDEN_PAGE_LABEL_COLOR_STR = "#D15E26";

	[Token(Token = "0x400D0D9")]
	private const float COLLECTION_BG_WITH_MASK_ALPHA = 0.4f;

	[Token(Token = "0x400D0DA")]
	private const float COLLECTION_BG_NORMAL_ALPHA = 1f;

	[Token(Token = "0x400D0DB")]
	private const float PROGRESS_BAR_UPDATE_DURATION = 0.7f;

	[Token(Token = "0x400D0DC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector2Int WEAPON_SPRITE_SIZE;

	[Token(Token = "0x400D0DD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Vector3 WEAPON_SPRITE_EULER_ANGLES;

	[Token(Token = "0x400D0DE")]
	[FieldOffset(Offset = "0x28")]
	private uint m_BookID;

	[Token(Token = "0x400D0DF")]
	[FieldOffset(Offset = "0x2C")]
	private int m_PageIdx;

	[Token(Token = "0x400D0E0")]
	[FieldOffset(Offset = "0x30")]
	private float m_ProgressBarTargetValue;

	[Token(Token = "0x400D0E1")]
	[FieldOffset(Offset = "0x34")]
	private Color m_CommonPageLabelColor;

	[Token(Token = "0x400D0E2")]
	[FieldOffset(Offset = "0x44")]
	private Color m_GrayPageLabelColor;

	[Token(Token = "0x400D0E3")]
	[FieldOffset(Offset = "0x54")]
	private Color m_HiddenPageLabelColor;

	[Token(Token = "0x400D0E4")]
	[FieldOffset(Offset = "0x64")]
	private Coroutine m_ProgressBarValueUpdateCoroutine;

	[Token(Token = "0x400D0E5")]
	[FieldOffset(Offset = "0x68")]
	private CollectionBookItemDesc m_PageItemDesc;

	[Token(Token = "0x400D0E6")]
	[FieldOffset(Offset = "0x6C")]
	private UIHyperBookContentPageItemView m_View;

	[Token(Token = "0x17001010")]
	private bool IsSetup
	{
		[Token(Token = "0x600AF43")]
		[Address(RVA = "0x2955FC0", Offset = "0x2955FC0", VA = "0x2955FC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001011")]
	private bool IsHiddenPage
	{
		[Token(Token = "0x600AF44")]
		[Address(RVA = "0x295603C", Offset = "0x295603C", VA = "0x295603C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001012")]
	private bool IsProgressBarShown
	{
		[Token(Token = "0x600AF45")]
		[Address(RVA = "0x29561D0", Offset = "0x29561D0", VA = "0x29561D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AF42")]
	[Address(RVA = "0x2955F34", Offset = "0x2955F34", VA = "0x2955F34")]
	public UIHyperBookContentPageItemController()
	{
	}

	[Token(Token = "0x600AF46")]
	[Address(RVA = "0x2956258", Offset = "0x2956258", VA = "0x2956258")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AF47")]
	[Address(RVA = "0x2956300", Offset = "0x2956300", VA = "0x2956300", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AF48")]
	[Address(RVA = "0x2956A18", Offset = "0x2956A18", VA = "0x2956A18", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AF49")]
	[Address(RVA = "0x29565F8", Offset = "0x29565F8", VA = "0x29565F8")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AF4A")]
	[Address(RVA = "0x2956838", Offset = "0x2956838", VA = "0x2956838")]
	private void SetupItemView()
	{
	}

	[Token(Token = "0x600AF4B")]
	[Address(RVA = "0x2956B94", Offset = "0x2956B94", VA = "0x2956B94")]
	private void LoadStaticContent()
	{
	}

	[Token(Token = "0x600AF4C")]
	[Address(RVA = "0x2956EC4", Offset = "0x2956EC4", VA = "0x2956EC4")]
	private void RefreshDynamicContent(bool playAnim = false)
	{
	}

	[Token(Token = "0x600AF4D")]
	[Address(RVA = "0x2958480", Offset = "0x2958480", VA = "0x2958480")]
	private void OnSelectBtnClick()
	{
	}

	[Token(Token = "0x600AF4E")]
	[Address(RVA = "0x29564C4", Offset = "0x29564C4", VA = "0x29564C4")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AF4F")]
	[Address(RVA = "0x2958D38", Offset = "0x2958D38", VA = "0x2958D38")]
	private CollectionBookItemDesc GetPageItemDesc()
	{
		return null;
	}

	[Token(Token = "0x600AF50")]
	[Address(RVA = "0x2957770", Offset = "0x2957770", VA = "0x2957770")]
	private float GetPageItemProgressValue()
	{
		return default(float);
	}

	[Token(Token = "0x600AF51")]
	[Address(RVA = "0x2957F6C", Offset = "0x2957F6C", VA = "0x2957F6C")]
	private Color GetPageIdxLabelColor(bool lightColor)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600AF52")]
	[Address(RVA = "0x2956A9C", Offset = "0x2956A9C", VA = "0x2956A9C")]
	private void SetCollectionBgAlpha(float alpha)
	{
	}

	[Token(Token = "0x600AF53")]
	[Address(RVA = "0x2958F6C", Offset = "0x2958F6C", VA = "0x2958F6C")]
	private void SetProgressBarValueInternal(float value)
	{
	}

	[Token(Token = "0x600AF54")]
	[Address(RVA = "0x295911C", Offset = "0x295911C", VA = "0x295911C")]
	private IEnumerator PlayProgressVarValueUpdateCoroutine(float value)
	{
		return null;
	}

	[Token(Token = "0x600AF55")]
	[Address(RVA = "0x2957AE8", Offset = "0x2957AE8", VA = "0x2957AE8")]
	private void SetProgressBarValueIfShown(float value, bool playAnim)
	{
	}

	[Token(Token = "0x600AF56")]
	[Address(RVA = "0x29563DC", Offset = "0x29563DC", VA = "0x29563DC")]
	private void PrepareColor()
	{
	}

	[Token(Token = "0x600AF57")]
	[Address(RVA = "0x29570C0", Offset = "0x29570C0", VA = "0x29570C0")]
	private void RefreshCollectionIcon()
	{
	}

	[Token(Token = "0x600AF58")]
	[Address(RVA = "0x2957568", Offset = "0x2957568", VA = "0x2957568")]
	private bool IsMaskNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF59")]
	[Address(RVA = "0x2958024", Offset = "0x2958024", VA = "0x2958024")]
	private bool IsTipsNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF5A")]
	[Address(RVA = "0x2957D78", Offset = "0x2957D78", VA = "0x2957D78")]
	private bool IsLabelColorLight()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF5B")]
	[Address(RVA = "0x294FB5C", Offset = "0x294FB5C", VA = "0x294FB5C")]
	public void RefreshContent()
	{
	}

	[Token(Token = "0x600AF5C")]
	[Address(RVA = "0x294FBC0", Offset = "0x294FBC0", VA = "0x294FBC0")]
	public void SetViewData(uint bookID, int pageIdx)
	{
	}

	[Token(Token = "0x600AF5D")]
	[Address(RVA = "0x2952250", Offset = "0x2952250", VA = "0x2952250")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x600AF5E")]
	[Address(RVA = "0x2952164", Offset = "0x2952164", VA = "0x2952164")]
	public void OnCancelSelect()
	{
	}

	[Token(Token = "0x600AF5F")]
	[Address(RVA = "0x2959220", Offset = "0x2959220", VA = "0x2959220")]
	private void NeedShowGuide()
	{
	}

	[Token(Token = "0x600AF61")]
	[Address(RVA = "0x2959778", Offset = "0x2959778", VA = "0x2959778")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AF62")]
	[Address(RVA = "0x2959780", Offset = "0x2959780", VA = "0x2959780")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
