using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002387")]
public class UIOperationSettingController : UISettingContentBase
{
	[Token(Token = "0x2002388")]
	private enum OperationSettingKey
	{
		[Token(Token = "0x400DD3C")]
		Aider,
		[Token(Token = "0x400DD3D")]
		LeftShot,
		[Token(Token = "0x400DD3E")]
		ChangeGun,
		[Token(Token = "0x400DD3F")]
		Reload,
		[Token(Token = "0x400DD40")]
		SniperMode,
		[Token(Token = "0x400DD41")]
		GrenadeSlot,
		[Token(Token = "0x400DD42")]
		SmartIceWall,
		[Token(Token = "0x400DD43")]
		VehicleControlMode,
		[Token(Token = "0x400DD44")]
		AutoSliding,
		[Token(Token = "0x400DD45")]
		FastMethod,
		[Token(Token = "0x400DD46")]
		ToggleATKContainer,
		[Token(Token = "0x400DD47")]
		ToggleZoneContainer,
		[Token(Token = "0x400DD48")]
		AutoPickup,
		[Token(Token = "0x400DD49")]
		SafezoneMode,
		[Token(Token = "0x400DD4A")]
		StackedKillMode,
		[Token(Token = "0x400DD4B")]
		DamageSetting,
		[Token(Token = "0x400DD4C")]
		AutoSwitchWeapon,
		[Token(Token = "0x400DD4D")]
		BloodMode,
		[Token(Token = "0x400DD4E")]
		UseAuxAim,
		[Token(Token = "0x400DD4F")]
		UseAuxAimParachute,
		[Token(Token = "0x400DD50")]
		UseAuxAimDash,
		[Token(Token = "0x400DD51")]
		UseAuxAimDrive,
		[Token(Token = "0x400DD52")]
		HitHint,
		[Token(Token = "0x400DD53")]
		NameAlphaGroup,
		[Token(Token = "0x400DD54")]
		EnemyFireHint,
		[Token(Token = "0x400DD55")]
		LobbyGyroscope
	}

	[Token(Token = "0x2002389")]
	private sealed class _003CRefreshScroll_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DD56")]
		[FieldOffset(Offset = "0x8")]
		internal UIOperationSettingController _0024this;

		[Token(Token = "0x400DD57")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DD58")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DD59")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010DC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C780")]
			[Address(RVA = "0x223B108", Offset = "0x223B108", VA = "0x223B108", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010DD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C781")]
			[Address(RVA = "0x223B110", Offset = "0x223B110", VA = "0x223B110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C77E")]
		[Address(RVA = "0x2233ADC", Offset = "0x2233ADC", VA = "0x2233ADC")]
		public _003CRefreshScroll_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C77F")]
		[Address(RVA = "0x223AFD0", Offset = "0x223AFD0", VA = "0x223AFD0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C782")]
		[Address(RVA = "0x223B118", Offset = "0x223B118", VA = "0x223B118", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C783")]
		[Address(RVA = "0x223B12C", Offset = "0x223B12C", VA = "0x223B12C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DD35")]
	[FieldOffset(Offset = "0x2C")]
	private UIOperationSettingView m_View;

	[Token(Token = "0x400DD36")]
	[FieldOffset(Offset = "0x30")]
	private OperationSettingInfo m_SettingInfo;

	[Token(Token = "0x400DD37")]
	[FieldOffset(Offset = "0x34")]
	private UICommonSettingContentController m_Ctrl;

	[Token(Token = "0x400DD38")]
	[FieldOffset(Offset = "0x38")]
	private CommonSettingContentData m_Data;

	[Token(Token = "0x400DD39")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DD3A")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600C717")]
	[Address(RVA = "0x22326D0", Offset = "0x22326D0", VA = "0x22326D0")]
	public UIOperationSettingController()
	{
	}

	[Token(Token = "0x600C718")]
	[Address(RVA = "0x2232748", Offset = "0x2232748", VA = "0x2232748")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C719")]
	[Address(RVA = "0x22327B0", Offset = "0x22327B0", VA = "0x22327B0", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C71A")]
	[Address(RVA = "0x22328A8", Offset = "0x22328A8", VA = "0x22328A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C71B")]
	[Address(RVA = "0x2233A58", Offset = "0x2233A58", VA = "0x2233A58")]
	private IEnumerator RefreshScroll()
	{
		return null;
	}

	[Token(Token = "0x600C71C")]
	[Address(RVA = "0x2233888", Offset = "0x2233888", VA = "0x2233888")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C71D")]
	[Address(RVA = "0x2233AE4", Offset = "0x2233AE4", VA = "0x2233AE4", Slot = "32")]
	protected override void InitSettingInfo()
	{
	}

	[Token(Token = "0x600C71E")]
	[Address(RVA = "0x2234044", Offset = "0x2234044", VA = "0x2234044", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C71F")]
	[Address(RVA = "0x2234EDC", Offset = "0x2234EDC", VA = "0x2234EDC")]
	public void OnCustomizeButtonClick()
	{
	}

	[Token(Token = "0x600C720")]
	[Address(RVA = "0x2232A84", Offset = "0x2232A84", VA = "0x2232A84")]
	private void CreateContentData()
	{
	}

	[Token(Token = "0x600C721")]
	[Address(RVA = "0x2234FA0", Offset = "0x2234FA0", VA = "0x2234FA0")]
	private CommonSettingItemDataToggleBtns CreateGrenadeSlotData()
	{
		return null;
	}

	[Token(Token = "0x600C722")]
	[Address(RVA = "0x2235380", Offset = "0x2235380", VA = "0x2235380")]
	private CommonSettingItemDataToggleBtns CreateSmartIceWallData()
	{
		return null;
	}

	[Token(Token = "0x600C723")]
	[Address(RVA = "0x2235708", Offset = "0x2235708", VA = "0x2235708")]
	private CommonSettingItemDataToggleBtns CreateFastMethodData()
	{
		return null;
	}

	[Token(Token = "0x600C724")]
	[Address(RVA = "0x22364F0", Offset = "0x22364F0", VA = "0x22364F0")]
	private CommonSettingItemDataToggleBtns CreateToggleATKContainerData()
	{
		return null;
	}

	[Token(Token = "0x600C725")]
	[Address(RVA = "0x2236770", Offset = "0x2236770", VA = "0x2236770")]
	private CommonSettingItemDataToggleBtns CreateToggleZoneContainerData()
	{
		return null;
	}

	[Token(Token = "0x600C726")]
	[Address(RVA = "0x22369F0", Offset = "0x22369F0", VA = "0x22369F0")]
	private CommonSettingItemDataToggleBtns CreateSafezoneModeData()
	{
		return null;
	}

	[Token(Token = "0x600C727")]
	[Address(RVA = "0x2236C70", Offset = "0x2236C70", VA = "0x2236C70")]
	private CommonSettingItemDataToggleBtns CreateDamageSettingData()
	{
		return null;
	}

	[Token(Token = "0x600C728")]
	[Address(RVA = "0x2235A8C", Offset = "0x2235A8C", VA = "0x2235A8C")]
	private CommonSettingItemDataToggleBtns CreateAutoSwitchWeaponData()
	{
		return null;
	}

	[Token(Token = "0x600C729")]
	[Address(RVA = "0x2236EF0", Offset = "0x2236EF0", VA = "0x2236EF0")]
	private CommonSettingItemDataToggleBtns CreateBloodModeData()
	{
		return null;
	}

	[Token(Token = "0x600C72A")]
	[Address(RVA = "0x2235D0C", Offset = "0x2235D0C", VA = "0x2235D0C")]
	private CommonSettingItemDataToggleBtns CreateUseAuxAimData()
	{
		return null;
	}

	[Token(Token = "0x600C72B")]
	[Address(RVA = "0x2237284", Offset = "0x2237284", VA = "0x2237284")]
	private CommonSettingItemDataToggleBtns CreateUseAuxAimParachuteData()
	{
		return null;
	}

	[Token(Token = "0x600C72C")]
	[Address(RVA = "0x2237560", Offset = "0x2237560", VA = "0x2237560")]
	private CommonSettingItemDataToggleBtns CreateUseAuxAimDashData()
	{
		return null;
	}

	[Token(Token = "0x600C72D")]
	[Address(RVA = "0x223783C", Offset = "0x223783C", VA = "0x223783C")]
	private CommonSettingItemDataToggleBtns CreateUseAuxAimDriveData()
	{
		return null;
	}

	[Token(Token = "0x600C72E")]
	[Address(RVA = "0x2237B18", Offset = "0x2237B18", VA = "0x2237B18")]
	private CommonSettingItemDataToggleBtns CreateHitHintData()
	{
		return null;
	}

	[Token(Token = "0x600C72F")]
	[Address(RVA = "0x2237D98", Offset = "0x2237D98", VA = "0x2237D98")]
	private CommonSettingItemDataToggleBtns CreateNameAlphaGroupData()
	{
		return null;
	}

	[Token(Token = "0x600C730")]
	[Address(RVA = "0x2235F8C", Offset = "0x2235F8C", VA = "0x2235F8C")]
	private CommonSettingItemDataToggleBtns CreateEnemyFireHintData()
	{
		return null;
	}

	[Token(Token = "0x600C731")]
	[Address(RVA = "0x2236270", Offset = "0x2236270", VA = "0x2236270")]
	private CommonSettingItemDataToggleBtns CreateLobbyGyroscope()
	{
		return null;
	}

	[Token(Token = "0x600C732")]
	[Address(RVA = "0x2238018", Offset = "0x2238018", VA = "0x2238018")]
	private int GetGrenadeSlotSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C733")]
	[Address(RVA = "0x22380B4", Offset = "0x22380B4", VA = "0x22380B4")]
	private int GetSmartIceWallSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C734")]
	[Address(RVA = "0x2238134", Offset = "0x2238134", VA = "0x2238134")]
	private int GetFastMethodSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C735")]
	[Address(RVA = "0x22381E0", Offset = "0x22381E0", VA = "0x22381E0")]
	private int GetToggleATKContainerSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C736")]
	[Address(RVA = "0x2238260", Offset = "0x2238260", VA = "0x2238260")]
	private int GetToggleZoneContainerSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C737")]
	[Address(RVA = "0x22382E0", Offset = "0x22382E0", VA = "0x22382E0")]
	private int GetSafeZoneModeSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C738")]
	[Address(RVA = "0x2238384", Offset = "0x2238384", VA = "0x2238384")]
	private int GetDamageSettingSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C739")]
	[Address(RVA = "0x2238410", Offset = "0x2238410", VA = "0x2238410")]
	private int GetAutoSwitchWeaponSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73A")]
	[Address(RVA = "0x2238490", Offset = "0x2238490", VA = "0x2238490")]
	private int GetBloodModeSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73B")]
	[Address(RVA = "0x2238518", Offset = "0x2238518", VA = "0x2238518")]
	private int GetUseAuxAimSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73C")]
	[Address(RVA = "0x22385B4", Offset = "0x22385B4", VA = "0x22385B4")]
	private int GetUseUseAuxAimParachuteSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73D")]
	[Address(RVA = "0x2238634", Offset = "0x2238634", VA = "0x2238634")]
	private int GetUseUseAuxAimDashSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73E")]
	[Address(RVA = "0x22386B4", Offset = "0x22386B4", VA = "0x22386B4")]
	private int GetUseUseAuxAimDriveSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C73F")]
	[Address(RVA = "0x2238734", Offset = "0x2238734", VA = "0x2238734")]
	private int GetHitHintSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C740")]
	[Address(RVA = "0x22387B0", Offset = "0x22387B0", VA = "0x22387B0")]
	private int GetNameAlphaGroupSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C741")]
	[Address(RVA = "0x223882C", Offset = "0x223882C", VA = "0x223882C")]
	private int GetEnemyFireHintSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C742")]
	[Address(RVA = "0x22388AC", Offset = "0x22388AC", VA = "0x22388AC")]
	private int GetLobbyGyroscopeSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C743")]
	[Address(RVA = "0x22327DC", Offset = "0x22327DC", VA = "0x22327DC")]
	private void RefreshBtnsState()
	{
	}

	[Token(Token = "0x600C744")]
	[Address(RVA = "0x223892C", Offset = "0x223892C", VA = "0x223892C")]
	private void OnStackedKillModeTipsClick()
	{
	}

	[Token(Token = "0x600C745")]
	[Address(RVA = "0x2238D40", Offset = "0x2238D40", VA = "0x2238D40")]
	private void OnGrenadeSlotClick(int value)
	{
	}

	[Token(Token = "0x600C746")]
	[Address(RVA = "0x2239090", Offset = "0x2239090", VA = "0x2239090")]
	private void OnGrenadeTipButtonClicked()
	{
	}

	[Token(Token = "0x600C747")]
	[Address(RVA = "0x22394A4", Offset = "0x22394A4", VA = "0x22394A4")]
	private bool GrenadeSlotIsEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x600C748")]
	[Address(RVA = "0x2239524", Offset = "0x2239524", VA = "0x2239524")]
	private void OnSmartIceWallSwitchClick(bool enable)
	{
	}

	[Token(Token = "0x600C749")]
	[Address(RVA = "0x2239744", Offset = "0x2239744", VA = "0x2239744")]
	private void OnSmartIceWallTipButtonClikced()
	{
	}

	[Token(Token = "0x600C74A")]
	[Address(RVA = "0x2239B58", Offset = "0x2239B58", VA = "0x2239B58")]
	private void ShowSmartIceWallGuide()
	{
	}

	[Token(Token = "0x600C74B")]
	[Address(RVA = "0x2239F0C", Offset = "0x2239F0C", VA = "0x2239F0C")]
	private void OnFastMethodClick(int value)
	{
	}

	[Token(Token = "0x600C74C")]
	[Address(RVA = "0x223A01C", Offset = "0x223A01C", VA = "0x223A01C")]
	private void OnFastMethodTipClick()
	{
	}

	[Token(Token = "0x600C74D")]
	[Address(RVA = "0x223A430", Offset = "0x223A430", VA = "0x223A430")]
	private void OnToggleATKContainerClick(bool value)
	{
	}

	[Token(Token = "0x600C74E")]
	[Address(RVA = "0x223A4B4", Offset = "0x223A4B4", VA = "0x223A4B4")]
	private void OnToggleZoneContainerClick(bool value)
	{
	}

	[Token(Token = "0x600C74F")]
	[Address(RVA = "0x223A538", Offset = "0x223A538", VA = "0x223A538")]
	private void OnSafeZoneModeClick(int value)
	{
	}

	[Token(Token = "0x600C750")]
	[Address(RVA = "0x223A708", Offset = "0x223A708", VA = "0x223A708")]
	private void OnDamageSettingClick(int value)
	{
	}

	[Token(Token = "0x600C751")]
	[Address(RVA = "0x223A78C", Offset = "0x223A78C", VA = "0x223A78C")]
	private void OnAutoSwitchWeaponClick(bool value)
	{
	}

	[Token(Token = "0x600C752")]
	[Address(RVA = "0x223A810", Offset = "0x223A810", VA = "0x223A810")]
	private void OnBloodModeClick(BloodType value)
	{
	}

	[Token(Token = "0x600C753")]
	[Address(RVA = "0x223A894", Offset = "0x223A894", VA = "0x223A894")]
	private void OnUseAuxAimClick(int value)
	{
	}

	[Token(Token = "0x600C754")]
	[Address(RVA = "0x223A950", Offset = "0x223A950", VA = "0x223A950")]
	private void OnUseAuxAimParachuteClick(int value)
	{
	}

	[Token(Token = "0x600C755")]
	[Address(RVA = "0x223A9E8", Offset = "0x223A9E8", VA = "0x223A9E8")]
	private void OnUseAuxAimDashClick(int value)
	{
	}

	[Token(Token = "0x600C756")]
	[Address(RVA = "0x223AA80", Offset = "0x223AA80", VA = "0x223AA80")]
	private void OnUseAuxAimDriveClick(int value)
	{
	}

	[Token(Token = "0x600C757")]
	[Address(RVA = "0x223AB18", Offset = "0x223AB18", VA = "0x223AB18")]
	private void OnHitHintClassicClick(bool value)
	{
	}

	[Token(Token = "0x600C758")]
	[Address(RVA = "0x223AB9C", Offset = "0x223AB9C", VA = "0x223AB9C")]
	private void OnNameAlphaGroupClassicClick(bool value)
	{
	}

	[Token(Token = "0x600C759")]
	[Address(RVA = "0x223AC20", Offset = "0x223AC20", VA = "0x223AC20")]
	private void OnLobbyGyroscopeClick(bool value)
	{
	}

	[Token(Token = "0x600C75A")]
	[Address(RVA = "0x223ADC0", Offset = "0x223ADC0", VA = "0x223ADC0")]
	private void _003CCreateGrenadeSlotData_003Em__0()
	{
	}

	[Token(Token = "0x600C75B")]
	[Address(RVA = "0x223ADC8", Offset = "0x223ADC8", VA = "0x223ADC8")]
	private void _003CCreateGrenadeSlotData_003Em__1()
	{
	}

	[Token(Token = "0x600C75C")]
	[Address(RVA = "0x223ADD0", Offset = "0x223ADD0", VA = "0x223ADD0")]
	private void _003CCreateSmartIceWallData_003Em__2()
	{
	}

	[Token(Token = "0x600C75D")]
	[Address(RVA = "0x223ADD8", Offset = "0x223ADD8", VA = "0x223ADD8")]
	private void _003CCreateSmartIceWallData_003Em__3()
	{
	}

	[Token(Token = "0x600C75E")]
	[Address(RVA = "0x223ADE0", Offset = "0x223ADE0", VA = "0x223ADE0")]
	private void _003CCreateFastMethodData_003Em__4()
	{
	}

	[Token(Token = "0x600C75F")]
	[Address(RVA = "0x223ADE8", Offset = "0x223ADE8", VA = "0x223ADE8")]
	private void _003CCreateFastMethodData_003Em__5()
	{
	}

	[Token(Token = "0x600C760")]
	[Address(RVA = "0x223ADF0", Offset = "0x223ADF0", VA = "0x223ADF0")]
	private void _003CCreateFastMethodData_003Em__6()
	{
	}

	[Token(Token = "0x600C761")]
	[Address(RVA = "0x223ADF8", Offset = "0x223ADF8", VA = "0x223ADF8")]
	private void _003CCreateToggleATKContainerData_003Em__7()
	{
	}

	[Token(Token = "0x600C762")]
	[Address(RVA = "0x223AE00", Offset = "0x223AE00", VA = "0x223AE00")]
	private void _003CCreateToggleATKContainerData_003Em__8()
	{
	}

	[Token(Token = "0x600C763")]
	[Address(RVA = "0x223AE08", Offset = "0x223AE08", VA = "0x223AE08")]
	private void _003CCreateToggleZoneContainerData_003Em__9()
	{
	}

	[Token(Token = "0x600C764")]
	[Address(RVA = "0x223AE10", Offset = "0x223AE10", VA = "0x223AE10")]
	private void _003CCreateToggleZoneContainerData_003Em__A()
	{
	}

	[Token(Token = "0x600C765")]
	[Address(RVA = "0x223AE18", Offset = "0x223AE18", VA = "0x223AE18")]
	private void _003CCreateSafezoneModeData_003Em__B()
	{
	}

	[Token(Token = "0x600C766")]
	[Address(RVA = "0x223AE20", Offset = "0x223AE20", VA = "0x223AE20")]
	private void _003CCreateSafezoneModeData_003Em__C()
	{
	}

	[Token(Token = "0x600C767")]
	[Address(RVA = "0x223AE28", Offset = "0x223AE28", VA = "0x223AE28")]
	private void _003CCreateDamageSettingData_003Em__D()
	{
	}

	[Token(Token = "0x600C768")]
	[Address(RVA = "0x223AE30", Offset = "0x223AE30", VA = "0x223AE30")]
	private void _003CCreateDamageSettingData_003Em__E()
	{
	}

	[Token(Token = "0x600C769")]
	[Address(RVA = "0x223AE38", Offset = "0x223AE38", VA = "0x223AE38")]
	private void _003CCreateAutoSwitchWeaponData_003Em__F()
	{
	}

	[Token(Token = "0x600C76A")]
	[Address(RVA = "0x223AE40", Offset = "0x223AE40", VA = "0x223AE40")]
	private void _003CCreateAutoSwitchWeaponData_003Em__10()
	{
	}

	[Token(Token = "0x600C76B")]
	[Address(RVA = "0x223AE48", Offset = "0x223AE48", VA = "0x223AE48")]
	private void _003CCreateBloodModeData_003Em__11()
	{
	}

	[Token(Token = "0x600C76C")]
	[Address(RVA = "0x223AE50", Offset = "0x223AE50", VA = "0x223AE50")]
	private void _003CCreateBloodModeData_003Em__12()
	{
	}

	[Token(Token = "0x600C76D")]
	[Address(RVA = "0x223AE58", Offset = "0x223AE58", VA = "0x223AE58")]
	private void _003CCreateBloodModeData_003Em__13()
	{
	}

	[Token(Token = "0x600C76E")]
	[Address(RVA = "0x223AE60", Offset = "0x223AE60", VA = "0x223AE60")]
	private void _003CCreateUseAuxAimData_003Em__14()
	{
	}

	[Token(Token = "0x600C76F")]
	[Address(RVA = "0x223AE68", Offset = "0x223AE68", VA = "0x223AE68")]
	private void _003CCreateUseAuxAimData_003Em__15()
	{
	}

	[Token(Token = "0x600C770")]
	[Address(RVA = "0x223AE70", Offset = "0x223AE70", VA = "0x223AE70")]
	private void _003CCreateUseAuxAimParachuteData_003Em__16()
	{
	}

	[Token(Token = "0x600C771")]
	[Address(RVA = "0x223AE78", Offset = "0x223AE78", VA = "0x223AE78")]
	private void _003CCreateUseAuxAimParachuteData_003Em__17()
	{
	}

	[Token(Token = "0x600C772")]
	[Address(RVA = "0x223AE80", Offset = "0x223AE80", VA = "0x223AE80")]
	private void _003CCreateUseAuxAimDashData_003Em__18()
	{
	}

	[Token(Token = "0x600C773")]
	[Address(RVA = "0x223AE88", Offset = "0x223AE88", VA = "0x223AE88")]
	private void _003CCreateUseAuxAimDashData_003Em__19()
	{
	}

	[Token(Token = "0x600C774")]
	[Address(RVA = "0x223AE90", Offset = "0x223AE90", VA = "0x223AE90")]
	private void _003CCreateUseAuxAimDriveData_003Em__1A()
	{
	}

	[Token(Token = "0x600C775")]
	[Address(RVA = "0x223AE98", Offset = "0x223AE98", VA = "0x223AE98")]
	private void _003CCreateUseAuxAimDriveData_003Em__1B()
	{
	}

	[Token(Token = "0x600C776")]
	[Address(RVA = "0x223AEA0", Offset = "0x223AEA0", VA = "0x223AEA0")]
	private void _003CCreateHitHintData_003Em__1C()
	{
	}

	[Token(Token = "0x600C777")]
	[Address(RVA = "0x223AEA8", Offset = "0x223AEA8", VA = "0x223AEA8")]
	private void _003CCreateHitHintData_003Em__1D()
	{
	}

	[Token(Token = "0x600C778")]
	[Address(RVA = "0x223AEB0", Offset = "0x223AEB0", VA = "0x223AEB0")]
	private void _003CCreateNameAlphaGroupData_003Em__1E()
	{
	}

	[Token(Token = "0x600C779")]
	[Address(RVA = "0x223AEB8", Offset = "0x223AEB8", VA = "0x223AEB8")]
	private void _003CCreateNameAlphaGroupData_003Em__1F()
	{
	}

	[Token(Token = "0x600C77A")]
	[Address(RVA = "0x223AEC0", Offset = "0x223AEC0", VA = "0x223AEC0")]
	private static void _003CCreateEnemyFireHintData_003Em__20()
	{
	}

	[Token(Token = "0x600C77B")]
	[Address(RVA = "0x223AF40", Offset = "0x223AF40", VA = "0x223AF40")]
	private static void _003CCreateEnemyFireHintData_003Em__21()
	{
	}

	[Token(Token = "0x600C77C")]
	[Address(RVA = "0x223AFC0", Offset = "0x223AFC0", VA = "0x223AFC0")]
	private void _003CCreateLobbyGyroscope_003Em__22()
	{
	}

	[Token(Token = "0x600C77D")]
	[Address(RVA = "0x223AFC8", Offset = "0x223AFC8", VA = "0x223AFC8")]
	private void _003CCreateLobbyGyroscope_003Em__23()
	{
	}
}
