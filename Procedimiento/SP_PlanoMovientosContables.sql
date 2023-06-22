
IF OBJECT_ID('SP_PlanoMovientosContables') IS NOT NULL
BEGIN
    DROP PROCEDURE SP_PlanoMovientosContables
    IF OBJECT_ID('SP_PlanoMovientosContables') IS NOT NULL
        PRINT '<<< FAILED DROPPING PROCEDURE SP_PlanoMovientosContables >>>'
    ELSE
        PRINT '<<< DROPPED PROCEDURE SP_PlanoMovientosContables >>>'
END
GO
CREATE PROCEDURE SP_PlanoMovientosContables
	@Details xml,
	@EMPRESA AS VARCHAR(3),
	@IDTERCERO AS VARCHAR(15),
	@CO AS VARCHAR(3),
	@TIPODOCTO AS VARCHAR(3),
	@FECHA AS DATE,
	@NOTAS AS VARCHAR(255),
	@USUARIO AS VARCHAR(50)
AS
/*
exec SP_PlanoMovientosContables 
JAIRO YESID LANCHEROS
DESCRIPCION: elimina movientos seleccionados
*/
BEGIN
DECLARE @mensaje AS VARCHAR(MAX) = '';
BEGIN TRANSACTION T1
		BEGIN TRY

			DECLARE @TablaDatos TABLE (
						CO VARCHAR(MAX),
						TERCERO	VARCHAR(MAX),
						SUCURSAL VARCHAR(MAX),
						CUENTA	VARCHAR(MAX),
						CENTROCOSTOS	VARCHAR(MAX),
						UN VARCHAR(MAX),
						VLRDEBITO VARCHAR(MAX),
						VLRCREDITO VARCHAR(MAX),
						BASE_GRAVABLE VARCHAR(MAX),
						VLDEBITO_NIIF VARCHAR(MAX),
						VLRCREDITO_NIIF	VARCHAR(MAX),
						BASE_GRAVABLE_NIIF VARCHAR(MAX),
						VALOR_DEBITO_LIBRO3 VARCHAR(MAX),
						VALOR_CREDITO_LIBRO3 VARCHAR(MAX),
						BASE_GRAVABLE_LIBRO3 VARCHAR(MAX),
						DOCTO_BANCO VARCHAR(MAX),
						NRO_DOCTO_BANCO	VARCHAR(MAX),
						AUX_FLUJO VARCHAR(MAX),
						NOTAS VARCHAR(MAX)
					  )
				BEGIN
						--EJECUTAR PROCESO
						INSERT INTO @TablaDatos
						select 
						  T.X.value('./CO[1]', 'nvarchar(MAX)') AS CO,
						  T.X.value('./TERCERO[1]', 'nvarchar(MAX)') ,
						  T.X.value('./SUCURSAL[1]', 'nvarchar(MAX)'),
						  T.X.value('./CUENTA[1]', 'nvarchar(MAX)') ,
						  T.X.value('./CENTROCOSTOS[1]', 'nvarchar(MAX)') ,
						  T.X.value('./UN[1]', 'nvarchar(MAX)'),
						  T.X.value('./VLRDEBITO[1]', 'nvarchar(MAX)'),
						  T.X.value('./VLRCREDITO[1]', 'nvarchar(MAX)') ,
						  T.X.value('./BASE_GRAVABLE[1]', 'nvarchar(MAX)') ,
						  T.X.value('./VLDEBITO_NIIF[1]', 'nvarchar(MAX)'),
						  T.X.value('./VLRCREDITO_NIIF[1]', 'nvarchar(MAX)'),
						  T.X.value('./BASE_GRAVABLE_NIIF[1]', 'nvarchar(MAX)') ,
						  T.X.value('./VALOR_DEBITO_LIBRO3[1]', 'nvarchar(MAX)') ,
						  T.X.value('./VALOR_CREDITO_LIBRO3[1]', 'nvarchar(MAX)') ,
						  T.X.value('./BASE_GRAVABLE_LIBRO3[1]', 'nvarchar(MAX)') ,
						  T.X.value('./DOCTO_BANCO[1]', 'nvarchar(MAX)'),
						  T.X.value('./NRO_DOCTO_BANCO[1]', 'nvarchar(MAX)') ,
						  T.X.value('./AUX_FLUJO[1]', 'nvarchar(MAX)') ,
						  T.X.value('./NOTAS[1]', 'nvarchar(MAX)') 
						from @Details.nodes('/NewDataSet/Excel') as T(X);
				END

					DECLARE @CONSCXC AS DECIMAL(18, 0)

		
					DELETE FROM Tbl_Plano WHERE Usuario  = @USUARIO
		
					DECLARE  @Tbl_ExpDctoContable AS TABLE(
						[F_NUMERO_REG] [varchar](7) NULL,
						[F_TIPO_REG] [varchar](4) NULL,
						[F_SUBTIPO_REG] [varchar](2) NULL,
						[F_VERSION_REG] [varchar](2) NULL,
						[F_CIA] [varchar](3) NULL,
						[F_CONSEC_AUTO_REG] [varchar](1) NULL,
						[F350_ID_CO] [varchar](3) NULL,
						[F350_ID_TIPO_DOCTO] [varchar](3) NULL,
						[F350_CONSEC_DOCTO] [varchar](8) NULL,
						[F350_FECHA] [varchar](8) NULL,
						[F350_ID_TERCERO] [varchar](15) NULL,
						[F350_ID_CLASE_DOCTO] [varchar](5) NULL,
						[F350_IND_ESTADO] [varchar](1) NULL,
						[F350_IND_IMPRESION] [varchar](1) NULL,
						[F350_NOTAS] [varchar](255) NULL,
						[f350_id_mandato] [varchar](15) NULL
						)


						INSERT INTO @Tbl_ExpDctoContable
						SELECT
							REPLICATE('0', 6) + '2',
							'0350',
							'00',
							'02',
							@EMPRESA,
							'1',
							@CO,
							@TIPODOCTO + REPLICATE(' ', 3 - LEN(@TIPODOCTO)),
							REPLICATE('0', 8),
							CAST(YEAR(@FECHA) AS VARCHAR(4)) + REPLICATE('0', 2 - LEN(MONTH(@FECHA))) + CAST(MONTH(@FECHA) AS VARCHAR(2))  + REPLICATE('0', 2 - LEN(DAY(@FECHA))) + CAST(DAY(@FECHA) AS VARCHAR(2)),
							@IDTERCERO + REPLICATE(' ', 15 - LEN(@IDTERCERO)),
							'00030',
							'0',
							'0',
							@NOTAS + REPLICATE(' ', 255 - LEN(@NOTAS)),
							REPLICATE(' ', 15)


								DECLARE @Tbl_ExpMovContable AS TABLE(
									[f_numero_reg] [varchar](7) NULL,
									[f_tipo_reg] [varchar](4) NULL,
									[f_subtipo_reg] [varchar](2) NULL,
									[f_version_reg] [varchar](2) NULL,
									[f_cia] [varchar](3) NULL,
									[f350_id_co] [varchar](3) NULL,
									[f350_id_tipo_docto] [varchar](3) NULL,
									[f350_consec_docto] [varchar](8) NULL,
									[f351_id_auxiliar] [varchar](20) NULL,
									[f351_id_tercero] [varchar](15) NULL,
									[f351_id_co_mov] [varchar](3) NULL,
									[f351_id_un] [varchar](20) NULL,
									[f351_id_ccosto] [varchar](15) NULL,
									[f351_id_fe] [varchar](10) NULL,
									[f351_valor_db] [varchar](21) NULL,
									[f351_valor_cr] [varchar](21) NULL,
									[f351_valor_db_alt] [varchar](21) NULL,
									[f351_valor_cr_alt] [varchar](21) NULL,
									[f351_base_gravable] [varchar](21) NULL,
									[f351_valor_db2] [varchar](21) NULL,
									[f351_valor_cr2] [varchar](21) NULL,
									[f351_valor_db_alt2] [varchar](21) NULL,
									[f351_valor_cr_alt2] [varchar](21) NULL,
									[f351_base_gravable2] [varchar](21) NULL,
									[f351_valor_db3] [varchar](21) NULL,
									[f351_valor_cr3] [varchar](21) NULL,
									[f351_valor_db_alt3] [varchar](21) NULL,
									[f351_valor_cr_alt3] [varchar](21) NULL,
									[f351_base_gravable3] [varchar](21) NULL,
									[f351_valor_imp_asum] [varchar](21) NULL,
									[f351_valor_imp_asum2] [varchar](21) NULL,
									[f351_valor_imp_asum3] [varchar](21) NULL,
									[f351_docto_banco] [varchar](2) NULL,
									[f351_nro_docto_banco] [varchar](8) NULL,
									[f351_nro_alt_docto_banco] [varchar](30) NULL,
									[f351_notas] [varchar](255) NULL
								)



							--MOVIMIENTO CONTABLE V4
							INSERT INTO @Tbl_ExpMovContable
							SELECT
								REPLICATE('0', (7 - LEN((ROW_NUMBER() OVER(ORDER BY TERCERO)) + 2))) + LTRIM(RTRIM(CAST(((ROW_NUMBER() OVER(ORDER BY TERCERO)) + 2) AS VARCHAR(100)))),
								'0351',
								'00',
								'04',
								@EMPRESA,
								@CO,
								@TIPODOCTO + REPLICATE(' ', 3 - LEN(@TIPODOCTO)),
								REPLICATE('0', 8),
								isnull(Cuenta,'') + REPLICATE(' ', 20 - LEN(isnull(Cuenta,''))),
								LTRIM(RTRIM(CAST(ISNULL(TERCERO,'') AS VARCHAR(40)))) + REPLICATE(' ', (15 - LEN(ISNULL(TERCERO,'')))),
								isnull(CO,''),
								isnull(UN,'') + REPLICATE(' ', 20 - LEN(isnull(UN,''))),
								ISNULL(CENTROCOSTOS,'') + REPLICATE(' ', 15 - LEN(ISNULL(CENTROCOSTOS,''))),
								ISNULL(AUX_FLUJO,'') + REPLICATE(' ', 10 - LEN(ISNULL(AUX_FLUJO,''))),
								(CASE WHEN CAST(VlrDebito AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VlrDebito AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VlrDebito AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(VlrCredito AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VlrCredito AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VlrCredito AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(BASE_GRAVABLE AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(BASE_GRAVABLE AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(BASE_GRAVABLE AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(VLDEBITO_NIIF AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VLDEBITO_NIIF AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VLDEBITO_NIIF AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(VLRCREDITO_NIIF AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VLRCREDITO_NIIF AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VLRCREDITO_NIIF AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(BASE_GRAVABLE_NIIF AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(BASE_GRAVABLE_NIIF AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(BASE_GRAVABLE_NIIF AS DECIMAL(18, 4)) AS VARCHAR(100)))),	   
								(CASE WHEN CAST(VALOR_DEBITO_LIBRO3 AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VALOR_DEBITO_LIBRO3 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VALOR_DEBITO_LIBRO3 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(VALOR_CREDITO_LIBRO3 AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(VALOR_CREDITO_LIBRO3 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(VALOR_CREDITO_LIBRO3 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								(CASE WHEN CAST(BASE_GRAVABLE_LIBRO3 AS DECIMAL(18, 4)) < 0 THEN '-' ELSE '+' END) + REPLICATE('0', (20 - LEN(CAST(BASE_GRAVABLE_LIBRO3 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(BASE_GRAVABLE_LIBRO3 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),			   
								'+' + REPLICATE('0', (20 - LEN(CAST(0 AS DECIMAL(18, 4)))))  +  LTRIM(RTRIM(CAST(CAST(0 AS DECIMAL(18, 4)) AS VARCHAR(100)))),			   	   
								isnull(DOCTO_BANCO,'') + REPLICATE(' ', 2 - LEN(isnull(DOCTO_BANCO,''))),
								REPLICATE('0', 8 - LEN(ISNULL(NRO_DOCTO_BANCO,0))) + ISNULL(NRO_DOCTO_BANCO,0),
								REPLICATE(' ', 30), 
								ISNULL(NOTAS,'') + REPLICATE(' ', 255 - LEN(ISNULL(NOTAS,'')))
								--REPLICATE(' ', 255)							
							FROM @TablaDatos
							

							
							SELECT @CONSCXC = (COUNT(1) + 2) FROM @Tbl_ExpMovContable


							INSERT INTO Tbl_Plano (Sarta, Usuario)
							SELECT ('000000100000001' + @EMPRESA), @USUARIO
							UNION
							SELECT        
							   (F_NUMERO_REG + 
								F_TIPO_REG + 
								F_SUBTIPO_REG + 
								F_VERSION_REG + 
								F_CIA + 
								F_CONSEC_AUTO_REG + 
								F350_ID_CO + 
								F350_ID_TIPO_DOCTO + 
								F350_CONSEC_DOCTO + 
								F350_FECHA + 
								F350_ID_TERCERO + 
								F350_ID_CLASE_DOCTO + 
								F350_IND_ESTADO + 
								F350_IND_IMPRESION + 
								F350_NOTAS +
								f350_id_mandato),
								@USUARIO
							FROM @Tbl_ExpDctoContable
							UNION
							SELECT 
							   (f_numero_reg +
								f_tipo_reg +
								f_subtipo_reg +
								f_version_reg +
								f_cia +
								f350_id_co +
								f350_id_tipo_docto +
								f350_consec_docto +
								f351_id_auxiliar +
								f351_id_tercero +
								f351_id_co_mov +
								f351_id_un +
								f351_id_ccosto +
								f351_id_fe +
								f351_valor_db +
								f351_valor_cr +
								f351_valor_db_alt +
								f351_valor_cr_alt +
								f351_base_gravable +
								f351_valor_db2 +
								f351_valor_cr2 +
								f351_valor_db_alt2 +
								f351_valor_cr_alt2 +
								f351_base_gravable2 +
								f351_valor_db3 +
								f351_valor_cr3 +
								f351_valor_db_alt3 +
								f351_valor_cr_alt3 +
								f351_base_gravable3 +
								f351_valor_imp_asum +
								f351_valor_imp_asum2 +
								f351_valor_imp_asum3 +
								f351_docto_banco +
								f351_nro_docto_banco +
								f351_nro_alt_docto_banco +
								f351_notas),
								@USUARIO
							FROM @Tbl_ExpMovContable
							UNION
							SELECT (REPLICATE('0', 7 - LEN(@CONSCXC+1)) + LTRIM(RTRIM(CAST((@CONSCXC+1) AS VARCHAR(7)))) + '99990001' + @EMPRESA), @USUARIO
							ORDER BY 1



			select @mensaje
			COMMIT TRANSACTION T1
		END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION T1
		set @mensaje = ERROR_MESSAGE()
		select @mensaje
	END CATCH

END
GO
IF OBJECT_ID('SP_PlanoMovientosContables') IS NOT NULL
    PRINT '<<< CREATED PROCEDURE SP_PlanoMovientosContables >>>'
ELSE
    PRINT '<<< FAILED CREATING PROCEDURE SP_PlanoMovientosContables >>>'

	