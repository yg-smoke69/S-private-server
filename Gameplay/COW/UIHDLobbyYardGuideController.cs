using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002127")]
public class UIHDLobbyYardGuideController : UIBaseController
{
	[Token(Token = "0x400CFA0")]
	[FieldOffset(Offset = "0x28")]
	private UIHDLobbyYardGuideView m_View;

	[Token(Token = "0x400CFA1")]
	public const string HDLOBBYYARDGUIDESHOW = "HDLobbyYardGuideShow_";

	[Token(Token = "0x400CFA2")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_DownTouchPos;

	[Token(Token = "0x400CFA3")]
	private const string TargetAreaName = "AvatarRotateTouchArea";

	[Token(Token = "0x600ADA2")]
	[Address(RVA = "0x20336B8", Offset = "0x20336B8", VA = "0x20336B8")]
	public UIHDLobbyYardGuideController()
	{
	}

	[Token(Token = "0x600ADA3")]
	[Address(RVA = "0x2033788", Offset = "0x2033788", VA = "0x2033788")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ADA4")]
	[Address(RVA = "0x203382C", Offset = "0x203382C", VA = "0x203382C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ADA5")]
	[Address(RVA = "0x2033A1C", Offset = "0x2033A1C", VA = "0x2033A1C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ADA6")]
	[Address(RVA = "0x2033BB8", Offset = "0x2033BB8", VA = "0x2033BB8")]
	private void CompleteGuide()
	{
	}

	[Token(Token = "0x600ADA7")]
	[Address(RVA = "0x2033D8C", Offset = "0x2033D8C", VA = "0x2033D8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600ADA8")]
	[Address(RVA = "0x2034188", Offset = "0x2034188", VA = "0x2034188")]
	private void OnLobbyControllerClosed(object[] data)
	{
	}

	[Token(Token = "0x600ADA9")]
	[Address(RVA = "0x2034274", Offset = "0x2034274", VA = "0x2034274")]
	private void OnGuideClose(object[] data)
	{
	}

	[Token(Token = "0x600ADAA")]
	[Address(RVA = "0x2033FC4", Offset = "0x2033FC4", VA = "0x2033FC4")]
	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADAB")]
	[Address(RVA = "0x20342E0", Offset = "0x20342E0", VA = "0x20342E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ADAC")]
	[Address(RVA = "0x20342E8", Offset = "0x20342E8", VA = "0x20342E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
