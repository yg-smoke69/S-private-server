using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CB7")]
public abstract class UIFrontEndPreviewHotFixDownloadBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewHotFixDownloadBaseView>
{
	[Token(Token = "0x2002CB8")]
	private sealed class _003CSetOptionalDownloadShow_003Ec__AnonStorey0
	{
		[Token(Token = "0x401111F")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> res_list;

		[Token(Token = "0x4011120")]
		[FieldOffset(Offset = "0xC")]
		internal string tempname;

		[Token(Token = "0x4011121")]
		[FieldOffset(Offset = "0x10")]
		internal UIFrontEndPreviewHotFixDownloadBaseController _0024this;

		[Token(Token = "0x6012B85")]
		[Address(RVA = "0x27FBCD8", Offset = "0x27FBCD8", VA = "0x27FBCD8")]
		public _003CSetOptionalDownloadShow_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012B86")]
		[Address(RVA = "0x27FBCE8", Offset = "0x27FBCE8", VA = "0x27FBCE8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401111C")]
	[FieldOffset(Offset = "0x38")]
	protected DownloadInfoSpecific m_DownloadInfoSpecific;

	[Token(Token = "0x401111D")]
	[FieldOffset(Offset = "0x3C")]
	protected UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x401111E")]
	[FieldOffset(Offset = "0x40")]
	protected ResDownloadType m_DownloadAllType;

	[Token(Token = "0x6012B7C")]
	[Address(RVA = "0x27FBA88", Offset = "0x27FBA88", VA = "0x27FBA88")]
	protected UIFrontEndPreviewHotFixDownloadBaseController()
	{
	}

	[Token(Token = "0x6012B7D")]
	[Address(RVA = "0x27FBAEC", Offset = "0x27FBAEC", VA = "0x27FBAEC", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012B7E")]
	[Address(RVA = "0x27E59A0", Offset = "0x27E59A0", VA = "0x27E59A0")]
	public void SetDownloadAllInfo(bool NeedShowDownloadAllBtn, ResDownloadType temptype = ResDownloadType.None, string downlownadllstr = "")
	{
	}

	[Token(Token = "0x6012B7F")]
	[Address(RVA = "0x27FBC84", Offset = "0x27FBC84", VA = "0x27FBC84", Slot = "36")]
	protected virtual void OnClickAll()
	{
	}

	[Token(Token = "0x6012B80")]
	[Address(RVA = "0x27F3174", Offset = "0x27F3174", VA = "0x27F3174")]
	public Vector2 GetItemDownloadBtnPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012B81")]
	[Address(RVA = "0x27F5790", Offset = "0x27F5790", VA = "0x27F5790")]
	public bool GetHotFixShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6012B82")]
	[Address(RVA = "0x27F5808", Offset = "0x27F5808", VA = "0x27F5808")]
	public void SetOptionalDownloadShow(bool show, [Optional] DownloadInfoSpecific downloadInfo)
	{
	}

	[Token(Token = "0x6012B83")]
	[Address(RVA = "0x27E9AC8", Offset = "0x27E9AC8", VA = "0x27E9AC8")]
	public void Download()
	{
	}

	[Token(Token = "0x6012B84")]
	[Address(RVA = "0x27FBCE0", Offset = "0x27FBCE0", VA = "0x27FBCE0")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
