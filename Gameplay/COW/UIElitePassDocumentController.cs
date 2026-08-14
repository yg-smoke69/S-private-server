using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20020C2")]
internal class UIElitePassDocumentController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x20020C3")]
	public class EPDocumentItemData
	{
		[Token(Token = "0x400CD2B")]
		[FieldOffset(Offset = "0x8")]
		public uint eventId;

		[Token(Token = "0x400CD2C")]
		[FieldOffset(Offset = "0xC")]
		public uint badgeId;

		[Token(Token = "0x400CD2D")]
		[FieldOffset(Offset = "0x10")]
		public string cdnUrl;

		[Token(Token = "0x400CD2E")]
		[FieldOffset(Offset = "0x14")]
		public bool ownedPass;

		[Token(Token = "0x400CD2F")]
		[FieldOffset(Offset = "0x18")]
		public uint badgeCnt;

		[Token(Token = "0x600A954")]
		[Address(RVA = "0x2A55DFC", Offset = "0x2A55DFC", VA = "0x2A55DFC")]
		public EPDocumentItemData(uint eventId, uint badgeId, string cdnUrl, bool ownedPass, uint badgeCnt)
		{
		}
	}

	[Token(Token = "0x20020C4")]
	private sealed class _003CSetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CD30")]
		[FieldOffset(Offset = "0x8")]
		internal EPEventSettingData localData;

		[Token(Token = "0x600A955")]
		[Address(RVA = "0x2A55DF4", Offset = "0x2A55DF4", VA = "0x2A55DF4")]
		public _003CSetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A956")]
		[Address(RVA = "0x2A562A8", Offset = "0x2A562A8", VA = "0x2A562A8")]
		internal bool _003C_003Em__0(EPArchiveInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CD29")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassDocumentView m_View;

	[Token(Token = "0x400CD2A")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x600A949")]
	[Address(RVA = "0x2A55328", Offset = "0x2A55328", VA = "0x2A55328")]
	public UIElitePassDocumentController()
	{
	}

	[Token(Token = "0x600A94A")]
	[Address(RVA = "0x2A55330", Offset = "0x2A55330", VA = "0x2A55330")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A94B")]
	[Address(RVA = "0x2A553D8", Offset = "0x2A553D8", VA = "0x2A553D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A94C")]
	[Address(RVA = "0x2A555CC", Offset = "0x2A555CC", VA = "0x2A555CC")]
	public void SetData(List<EPArchiveInfo> serverDataList)
	{
	}

	[Token(Token = "0x600A94D")]
	[Address(RVA = "0x2A55E3C", Offset = "0x2A55E3C", VA = "0x2A55E3C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A94E")]
	[Address(RVA = "0x2A55EC4", Offset = "0x2A55EC4", VA = "0x2A55EC4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A94F")]
	[Address(RVA = "0x2A55FBC", Offset = "0x2A55FBC", VA = "0x2A55FBC", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A950")]
	[Address(RVA = "0x2A56038", Offset = "0x2A56038", VA = "0x2A56038", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A951")]
	[Address(RVA = "0x2A56204", Offset = "0x2A56204", VA = "0x2A56204", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A952")]
	[Address(RVA = "0x2A56298", Offset = "0x2A56298", VA = "0x2A56298")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A953")]
	[Address(RVA = "0x2A562A0", Offset = "0x2A562A0", VA = "0x2A562A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
