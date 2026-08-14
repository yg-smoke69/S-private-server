using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C10")]
internal class UIWeaponSkinUpgraderFeatureController : UIPopupWindowController
{
	[Token(Token = "0x2002C11")]
	private class ModelTransformerAttri
	{
		[Token(Token = "0x4010D45")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 m_Pos;

		[Token(Token = "0x4010D46")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 m_Rot;

		[Token(Token = "0x4010D47")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_Scale;

		[Token(Token = "0x601253E")]
		[Address(RVA = "0x2EFD774", Offset = "0x2EFD774", VA = "0x2EFD774")]
		public ModelTransformerAttri(Vector3 pos, Vector3 rot, Vector3 scale)
		{
		}
	}

	[Token(Token = "0x4010D36")]
	[FieldOffset(Offset = "0x48")]
	private UIWeaponSkinUpgraderFeatureView m_View;

	[Token(Token = "0x4010D37")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_FeatureModel;

	[Token(Token = "0x4010D38")]
	[FieldOffset(Offset = "0x50")]
	private UIWeaponKillNotificationItemController m_AnnouncementCtrl;

	[Token(Token = "0x4010D39")]
	[FieldOffset(Offset = "0x54")]
	private Transform m_FeatureSubTrans;

	[Token(Token = "0x4010D3A")]
	[FieldOffset(Offset = "0x58")]
	private UIMaleAvatar m_FeatureAvatar;

	[Token(Token = "0x4010D3B")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject m_FeatureCamera;

	[Token(Token = "0x4010D3C")]
	[FieldOffset(Offset = "0x60")]
	private CSSharedItemData m_Data;

	[Token(Token = "0x4010D3D")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsWeaponSkinFeature;

	[Token(Token = "0x4010D3E")]
	[FieldOffset(Offset = "0x68")]
	private WeaponSkinData m_WeaponSkinData;

	[Token(Token = "0x4010D3F")]
	[FieldOffset(Offset = "0x6C")]
	private WeaponSkinFeature m_WeaponSkinFeature;

	[Token(Token = "0x4010D40")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x4010D41")]
	[FieldOffset(Offset = "0x70")]
	private bool m_NeedRotate;

	[Token(Token = "0x4010D42")]
	[FieldOffset(Offset = "0x74")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4010D43")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, ModelTransformerAttri> m_TransAttriDict;

	[Token(Token = "0x4010D44")]
	[FieldOffset(Offset = "0x78")]
	public Action m_CloseAction;

	[Token(Token = "0x601250F")]
	[Address(RVA = "0x2EF6FBC", Offset = "0x2EF6FBC", VA = "0x2EF6FBC")]
	public UIWeaponSkinUpgraderFeatureController()
	{
	}

	[Token(Token = "0x6012510")]
	[Address(RVA = "0x2EF6FCC", Offset = "0x2EF6FCC", VA = "0x2EF6FCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012511")]
	[Address(RVA = "0x2EF7070", Offset = "0x2EF7070", VA = "0x2EF7070", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012512")]
	[Address(RVA = "0x2EF78E4", Offset = "0x2EF78E4", VA = "0x2EF78E4", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6012513")]
	[Address(RVA = "0x2EF7A00", Offset = "0x2EF7A00", VA = "0x2EF7A00")]
	public void ShowFeatureView(WeaponSkinData data, WeaponSkinFeature feature)
	{
	}

	[Token(Token = "0x6012514")]
	[Address(RVA = "0x2EF9120", Offset = "0x2EF9120", VA = "0x2EF9120")]
	private void CreateFeature()
	{
	}

	[Token(Token = "0x6012515")]
	[Address(RVA = "0x2EF9AB8", Offset = "0x2EF9AB8", VA = "0x2EF9AB8")]
	private void UpdateSkinMeshRender(bool flag)
	{
	}

	[Token(Token = "0x6012516")]
	[Address(RVA = "0x2EF9D2C", Offset = "0x2EF9D2C", VA = "0x2EF9D2C")]
	private void OnShowFeature(object[] data)
	{
	}

	[Token(Token = "0x6012517")]
	[Address(RVA = "0x2EF7CF8", Offset = "0x2EF7CF8", VA = "0x2EF7CF8")]
	private void EnableUI(bool v)
	{
	}

	[Token(Token = "0x6012518")]
	[Address(RVA = "0x2EFAFF8", Offset = "0x2EFAFF8", VA = "0x2EFAFF8")]
	public void SetFeatureCameraDepth(float depth)
	{
	}

	[Token(Token = "0x6012519")]
	[Address(RVA = "0x2EFB174", Offset = "0x2EFB174", VA = "0x2EFB174")]
	public void Set3DModelVisiable(bool b)
	{
	}

	[Token(Token = "0x601251A")]
	[Address(RVA = "0x2EF8D90", Offset = "0x2EF8D90", VA = "0x2EF8D90")]
	private void CreateCamera()
	{
	}

	[Token(Token = "0x601251B")]
	[Address(RVA = "0x2EF934C", Offset = "0x2EF934C", VA = "0x2EF934C")]
	private void CreateFetureItem()
	{
	}

	[Token(Token = "0x601251C")]
	[Address(RVA = "0x2EF7484", Offset = "0x2EF7484", VA = "0x2EF7484")]
	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	[Token(Token = "0x601251D")]
	[Address(RVA = "0x2EFA9B4", Offset = "0x2EFA9B4", VA = "0x2EFA9B4")]
	public void RefreshWeaponPropertyScore(bool isShow)
	{
	}

	[Token(Token = "0x601251E")]
	[Address(RVA = "0x2EFB29C", Offset = "0x2EFB29C", VA = "0x2EFB29C")]
	private bool CheckItemABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x601251F")]
	[Address(RVA = "0x2EFB480", Offset = "0x2EFB480", VA = "0x2EFB480")]
	private void CreateRigidbody(ResourceID resID)
	{
	}

	[Token(Token = "0x6012520")]
	[Address(RVA = "0x2EFA17C", Offset = "0x2EFA17C", VA = "0x2EFA17C")]
	private void Adjust3DModel(Dictionary<int, ModelTransformerAttri> transAttriDict)
	{
	}

	[Token(Token = "0x6012521")]
	[Address(RVA = "0x2EF8D04", Offset = "0x2EF8D04", VA = "0x2EF8D04")]
	private void SetDoNeedRotate()
	{
	}

	[Token(Token = "0x6012522")]
	[Address(RVA = "0x2EFB6AC", Offset = "0x2EFB6AC", VA = "0x2EFB6AC")]
	private Transform GetSubTransfrom()
	{
		return null;
	}

	[Token(Token = "0x6012523")]
	[Address(RVA = "0x2EFB7DC", Offset = "0x2EFB7DC", VA = "0x2EFB7DC")]
	private void Rotate3DModel()
	{
	}

	[Token(Token = "0x6012524")]
	[Address(RVA = "0x2EFBC64", Offset = "0x2EFBC64", VA = "0x2EFBC64")]
	private void Update()
	{
	}

	[Token(Token = "0x6012525")]
	[Address(RVA = "0x2EFBCD4", Offset = "0x2EFBCD4", VA = "0x2EFBCD4")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x6012526")]
	[Address(RVA = "0x2EFBD38", Offset = "0x2EFBD38", VA = "0x2EFBD38")]
	private void OnShareBtnClik()
	{
	}

	[Token(Token = "0x6012527")]
	[Address(RVA = "0x2EFC2D4", Offset = "0x2EFC2D4", VA = "0x2EFC2D4", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6012528")]
	[Address(RVA = "0x2EFC344", Offset = "0x2EFC344", VA = "0x2EFC344", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6012529")]
	[Address(RVA = "0x2EFC3B4", Offset = "0x2EFC3B4", VA = "0x2EFC3B4", Slot = "27")]
	public override void BeforeSharePreview()
	{
	}

	[Token(Token = "0x601252A")]
	[Address(RVA = "0x2EFC424", Offset = "0x2EFC424", VA = "0x2EFC424", Slot = "28")]
	public override void AfterSharePreview()
	{
	}

	[Token(Token = "0x601252B")]
	[Address(RVA = "0x2EF7DB0", Offset = "0x2EF7DB0", VA = "0x2EF7DB0")]
	private void SetShareUIVisiable(bool isScreenShot)
	{
	}

	[Token(Token = "0x601252C")]
	[Address(RVA = "0x2EFB3E8", Offset = "0x2EFB3E8", VA = "0x2EFB3E8")]
	private void SetTouchEnable(bool b)
	{
	}

	[Token(Token = "0x601252D")]
	[Address(RVA = "0x2EF8BC4", Offset = "0x2EF8BC4", VA = "0x2EF8BC4")]
	private void AdjustBGScale()
	{
	}

	[Token(Token = "0x601252E")]
	[Address(RVA = "0x2EF7F40", Offset = "0x2EF7F40", VA = "0x2EF7F40")]
	private void UpdateViewInfo()
	{
	}

	[Token(Token = "0x601252F")]
	[Address(RVA = "0x2EFC494", Offset = "0x2EFC494", VA = "0x2EFC494")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x6012530")]
	[Address(RVA = "0x2EFBEEC", Offset = "0x2EFBEEC", VA = "0x2EFBEEC")]
	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	[Token(Token = "0x6012531")]
	[Address(RVA = "0x2EF90CC", Offset = "0x2EF90CC", VA = "0x2EF90CC")]
	private void PlayPopWndSound()
	{
	}

	[Token(Token = "0x6012532")]
	[Address(RVA = "0x2EFC958", Offset = "0x2EFC958", VA = "0x2EFC958")]
	private void Destroy3DModel()
	{
	}

	[Token(Token = "0x6012533")]
	[Address(RVA = "0x2EFCB0C", Offset = "0x2EFCB0C", VA = "0x2EFCB0C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012534")]
	[Address(RVA = "0x2EFCC00", Offset = "0x2EFCC00", VA = "0x2EFCC00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012536")]
	[Address(RVA = "0x2EFD7CC", Offset = "0x2EFD7CC", VA = "0x2EFD7CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012537")]
	[Address(RVA = "0x2EFD7D4", Offset = "0x2EFD7D4", VA = "0x2EFD7D4")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6012538")]
	[Address(RVA = "0x2EFD7DC", Offset = "0x2EFD7DC", VA = "0x2EFD7DC")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6012539")]
	[Address(RVA = "0x2EFD7E4", Offset = "0x2EFD7E4", VA = "0x2EFD7E4")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x601253A")]
	[Address(RVA = "0x2EFD7EC", Offset = "0x2EFD7EC", VA = "0x2EFD7EC")]
	public void _003C_003EiFixBaseProxy_BeforeSharePreview()
	{
	}

	[Token(Token = "0x601253B")]
	[Address(RVA = "0x2EFD7F4", Offset = "0x2EFD7F4", VA = "0x2EFD7F4")]
	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}

	[Token(Token = "0x601253C")]
	[Address(RVA = "0x2EFD7FC", Offset = "0x2EFD7FC", VA = "0x2EFD7FC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601253D")]
	[Address(RVA = "0x2EFD804", Offset = "0x2EFD804", VA = "0x2EFD804")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
