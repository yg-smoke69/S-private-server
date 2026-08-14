using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002737")]
public class UIHudEnemyHypeLevelController : UIHudNameBaseController
{
	[Token(Token = "0x400F212")]
	[FieldOffset(Offset = "0x50")]
	private UIHudEnemyHypeLevelView m_View;

	[Token(Token = "0x400F213")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_TargetPlayerID;

	[Token(Token = "0x400F214")]
	[FieldOffset(Offset = "0x70")]
	private uint m_DelayCallID;

	[Token(Token = "0x600EF01")]
	[Address(RVA = "0x1CE2DCC", Offset = "0x1CE2DCC", VA = "0x1CE2DCC")]
	public UIHudEnemyHypeLevelController()
	{
	}

	[Token(Token = "0x600EF02")]
	[Address(RVA = "0x1CE2E78", Offset = "0x1CE2E78", VA = "0x1CE2E78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF03")]
	[Address(RVA = "0x1CE2F20", Offset = "0x1CE2F20", VA = "0x1CE2F20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF04")]
	[Address(RVA = "0x1CE2FDC", Offset = "0x1CE2FDC", VA = "0x1CE2FDC")]
	public void BindPlayer(IHAAMHPPLMG pID, int hypeLevel)
	{
	}

	[Token(Token = "0x600EF05")]
	[Address(RVA = "0x1CE3254", Offset = "0x1CE3254", VA = "0x1CE3254", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF06")]
	[Address(RVA = "0x1CE359C", Offset = "0x1CE359C", VA = "0x1CE359C", Slot = "43")]
	protected override Vector3 ExtraScreenGap()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF07")]
	[Address(RVA = "0x1CE3624", Offset = "0x1CE3624", VA = "0x1CE3624")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF08")]
	[Address(RVA = "0x1CE362C", Offset = "0x1CE362C", VA = "0x1CE362C")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF09")]
	[Address(RVA = "0x1CE3640", Offset = "0x1CE3640", VA = "0x1CE3640")]
	public Vector3 _003C_003EiFixBaseProxy_ExtraScreenGap()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
