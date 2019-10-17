@ModelType IndexViewModel
@Code
    ViewBag.Title = "Administrar"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Cambiar la configuración de la cuenta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Contraseña:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Cambiar la contraseña", "ChangePassword")
            Else
                @Html.ActionLink("Crear", "SetPassword")
            End If
            ]
        </dd>
        <dt>Inicios de sesión externos:</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Administrar", "ManageLogins") ]
        </dd>
        @*
            Los números de teléfono se pueden usar como una segunda fase de comprobación en un sistema de autenticación en dos fases.
             
             Consulte <a href="https://go.microsoft.com/fwlink/?LinkId=403804">este artículo</a>
                para obtener detalles sobre cómo configurar esta aplicación ASP.NET para que sea compatible con la autenticación en dos fases mediante SMS.
             
             Quite la marca de comentario del bloque siguiente después de configurar la autenticación en dos fases
        *@
        @* 
            <dt>Número de teléfono:</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Quitar" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
        *@
        <dt>Autenticación de dos factores:</dt>
        <dd>
            <p>
                No hay ningún proveedor de autenticación en dos fases configurado. Consulte <a href="https://go.microsoft.com/fwlink/?LinkId=403804">este artículo</a>
                para obtener detalles sobre cómo configurar esta aplicación ASP.NET para que sea compatible con la autenticación en dos fases.
            </p>
            @*
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Habilitado
                      <input type="submit" value="Deshabilitar" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Deshabilitada
                      <input type="submit" value="Habilitar" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
