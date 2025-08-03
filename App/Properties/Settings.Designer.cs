// Add these properties to the Settings.Designer.cs file

[global::System.Configuration.UserScopedSettingAttribute()]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.ComponentModel.DefaultSettingValueAttribute("800")]
public int WindowWidth {
    get {
        return ((int)(this["WindowWidth"]));
    }
    set {
        this["WindowWidth"] = value;
    }
}

[global::System.Configuration.UserScopedSettingAttribute()]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.ComponentModel.DefaultSettingValueAttribute("600")]
public int WindowHeight {
    get {
        return ((int)(this["WindowHeight"]));
    }
    set {
        this["WindowHeight"] = value;
    }
}