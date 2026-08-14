using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003352")]
public class UIHudPetSkillTemplateController : UIBaseController
{
	[Token(Token = "0x40138CA")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetSkillTemplateView m_View;

	[Token(Token = "0x40138CB")]
	[FieldOffset(Offset = "0x2C")]
	private UICamera m_UICamera;

	[Token(Token = "0x40138CC")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_Camera;

	[Token(Token = "0x40138CD")]
	[FieldOffset(Offset = "0x34")]
	private float dist;

	[Token(Token = "0x6015D25")]
	[Address(RVA = "0x1852C48", Offset = "0x1852C48", VA = "0x1852C48")]
	public UIHudPetSkillTemplateController()
	{
	}

	[Token(Token = "0x6015D26")]
	[Address(RVA = "0x1852CCC", Offset = "0x1852CCC", VA = "0x1852CCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015D27")]
	[Address(RVA = "0x1852D70", Offset = "0x1852D70", VA = "0x1852D70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015D28")]
	[Address(RVA = "0x1852F50", Offset = "0x1852F50", VA = "0x1852F50")]
	public void RefreshSkillData(PetSkillLevelData data)
	{
	}

	[Token(Token = "0x6015D29")]
	[Address(RVA = "0x1853320", Offset = "0x1853320", VA = "0x1853320", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015D2A")]
	[Address(RVA = "0x1853384", Offset = "0x1853384", VA = "0x1853384")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x6015D2B")]
	[Address(RVA = "0x18534E8", Offset = "0x18534E8", VA = "0x18534E8")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6015D2C")]
	[Address(RVA = "0x1853858", Offset = "0x1853858", VA = "0x1853858")]
	private bool CheckMobileTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x6015D2D")]
	[Address(RVA = "0x1853950", Offset = "0x1853950", VA = "0x1853950")]
	private bool CheckPcTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6015D2E")]
	[Address(RVA = "0x1853A60", Offset = "0x1853A60", VA = "0x1853A60")]
	private void Update()
	{
	}

	[Token(Token = "0x6015D2F")]
	[Address(RVA = "0x1853CB0", Offset = "0x1853CB0", VA = "0x1853CB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D30")]
	[Address(RVA = "0x1853CB8", Offset = "0x1853CB8", VA = "0x1853CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
