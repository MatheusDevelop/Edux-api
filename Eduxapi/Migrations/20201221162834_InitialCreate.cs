using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eduxapi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nickname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "instituicaos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nickname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instituicaos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "professores",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nickname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "segredos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    nomeSegredo = table.Column<string>(nullable: true),
                    urlImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segredos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Nickname = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true),
                    isAluno = table.Column<bool>(nullable: false),
                    isInstituicao = table.Column<bool>(nullable: false),
                    isProfessor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    pontos = table.Column<int>(nullable: false),
                    alunoid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rank_alunos_alunoid",
                        column: x => x.alunoid,
                        principalTable: "alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "alunoInstituicao",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    alunoid = table.Column<Guid>(nullable: true),
                    instituicaoid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunoInstituicao", x => x.id);
                    table.ForeignKey(
                        name: "FK_alunoInstituicao_alunos_alunoid",
                        column: x => x.alunoid,
                        principalTable: "alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alunoInstituicao_instituicaos_instituicaoid",
                        column: x => x.instituicaoid,
                        principalTable: "instituicaos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    nomeCurso = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    Instituicaoid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.id);
                    table.ForeignKey(
                        name: "FK_cursos_instituicaos_Instituicaoid",
                        column: x => x.Instituicaoid,
                        principalTable: "instituicaos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "professorInstituicao",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    instituicaoid = table.Column<Guid>(nullable: true),
                    professorid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professorInstituicao", x => x.id);
                    table.ForeignKey(
                        name: "FK_professorInstituicao_instituicaos_instituicaoid",
                        column: x => x.instituicaoid,
                        principalTable: "instituicaos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_professorInstituicao_professores_professorid",
                        column: x => x.professorid,
                        principalTable: "professores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    usuarioid = table.Column<Guid>(nullable: false),
                    urlImg = table.Column<string>(nullable: true),
                    titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_posts_usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "segredousuario",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    segredoid = table.Column<Guid>(nullable: false),
                    usuarioid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_segredousuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_segredousuario_segredos_segredoid",
                        column: x => x.segredoid,
                        principalTable: "segredos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_segredousuario_usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "turmas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    instituicaoid = table.Column<Guid>(nullable: false),
                    cursoid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turmas", x => x.id);
                    table.ForeignKey(
                        name: "FK_turmas_cursos_cursoid",
                        column: x => x.cursoid,
                        principalTable: "cursos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_turmas_instituicaos_instituicaoid",
                        column: x => x.instituicaoid,
                        principalTable: "instituicaos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "curtidas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    usuarioid = table.Column<Guid>(nullable: false),
                    postid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curtidas", x => x.id);
                    table.ForeignKey(
                        name: "FK_curtidas_posts_postid",
                        column: x => x.postid,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_curtidas_usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "alunoTurmas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    alunoid = table.Column<Guid>(nullable: false),
                    turmaid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunoTurmas", x => x.id);
                    table.ForeignKey(
                        name: "FK_alunoTurmas_alunos_alunoid",
                        column: x => x.alunoid,
                        principalTable: "alunos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alunoTurmas_turmas_turmaid",
                        column: x => x.turmaid,
                        principalTable: "turmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "objetivos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    turmaid = table.Column<Guid>(nullable: false),
                    descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objetivos", x => x.id);
                    table.ForeignKey(
                        name: "FK_objetivos_turmas_turmaid",
                        column: x => x.turmaid,
                        principalTable: "turmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "professorTurmas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    professorid = table.Column<Guid>(nullable: false),
                    turmaid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professorTurmas", x => x.id);
                    table.ForeignKey(
                        name: "FK_professorTurmas_professores_professorid",
                        column: x => x.professorid,
                        principalTable: "professores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_professorTurmas_turmas_turmaid",
                        column: x => x.turmaid,
                        principalTable: "turmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "objetivosAtribuidos",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    alunoturmaid = table.Column<Guid>(nullable: true),
                    tarefa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objetivosAtribuidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_objetivosAtribuidos_alunoTurmas_alunoturmaid",
                        column: x => x.alunoturmaid,
                        principalTable: "alunoTurmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "objetivosConcluido",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    alunoid = table.Column<Guid>(nullable: false),
                    objetivoid = table.Column<Guid>(nullable: false),
                    nota = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objetivosConcluido", x => x.id);
                    table.ForeignKey(
                        name: "FK_objetivosConcluido_alunoTurmas_alunoid",
                        column: x => x.alunoid,
                        principalTable: "alunoTurmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_objetivosConcluido_objetivos_objetivoid",
                        column: x => x.objetivoid,
                        principalTable: "objetivos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alunoInstituicao_alunoid",
                table: "alunoInstituicao",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_alunoInstituicao_instituicaoid",
                table: "alunoInstituicao",
                column: "instituicaoid");

            migrationBuilder.CreateIndex(
                name: "IX_alunoTurmas_alunoid",
                table: "alunoTurmas",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_alunoTurmas_turmaid",
                table: "alunoTurmas",
                column: "turmaid");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_Instituicaoid",
                table: "cursos",
                column: "Instituicaoid");

            migrationBuilder.CreateIndex(
                name: "IX_curtidas_postid",
                table: "curtidas",
                column: "postid");

            migrationBuilder.CreateIndex(
                name: "IX_curtidas_usuarioid",
                table: "curtidas",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_objetivos_turmaid",
                table: "objetivos",
                column: "turmaid");

            migrationBuilder.CreateIndex(
                name: "IX_objetivosAtribuidos_alunoturmaid",
                table: "objetivosAtribuidos",
                column: "alunoturmaid");

            migrationBuilder.CreateIndex(
                name: "IX_objetivosConcluido_alunoid",
                table: "objetivosConcluido",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_objetivosConcluido_objetivoid",
                table: "objetivosConcluido",
                column: "objetivoid");

            migrationBuilder.CreateIndex(
                name: "IX_posts_usuarioid",
                table: "posts",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_professorInstituicao_instituicaoid",
                table: "professorInstituicao",
                column: "instituicaoid");

            migrationBuilder.CreateIndex(
                name: "IX_professorInstituicao_professorid",
                table: "professorInstituicao",
                column: "professorid");

            migrationBuilder.CreateIndex(
                name: "IX_professorTurmas_professorid",
                table: "professorTurmas",
                column: "professorid");

            migrationBuilder.CreateIndex(
                name: "IX_professorTurmas_turmaid",
                table: "professorTurmas",
                column: "turmaid");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_alunoid",
                table: "Rank",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_segredousuario_segredoid",
                table: "segredousuario",
                column: "segredoid");

            migrationBuilder.CreateIndex(
                name: "IX_segredousuario_usuarioid",
                table: "segredousuario",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_turmas_cursoid",
                table: "turmas",
                column: "cursoid");

            migrationBuilder.CreateIndex(
                name: "IX_turmas_instituicaoid",
                table: "turmas",
                column: "instituicaoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunoInstituicao");

            migrationBuilder.DropTable(
                name: "curtidas");

            migrationBuilder.DropTable(
                name: "objetivosAtribuidos");

            migrationBuilder.DropTable(
                name: "objetivosConcluido");

            migrationBuilder.DropTable(
                name: "professorInstituicao");

            migrationBuilder.DropTable(
                name: "professorTurmas");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "segredousuario");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "alunoTurmas");

            migrationBuilder.DropTable(
                name: "objetivos");

            migrationBuilder.DropTable(
                name: "professores");

            migrationBuilder.DropTable(
                name: "segredos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "alunos");

            migrationBuilder.DropTable(
                name: "turmas");

            migrationBuilder.DropTable(
                name: "cursos");

            migrationBuilder.DropTable(
                name: "instituicaos");
        }
    }
}
