import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public cadastro = new FormGroup({
    nome: new FormControl(''),
    materia: new FormControl(''),
    nota1: new FormControl(''),
    nota2: new FormControl(''),
    nota3: new FormControl('')
  });
  
  Alunos: any;

  constructor(private http: HttpClient) { }


  handleSubmit() {
    const dados = this.cadastro.value
    // console.log('Nome:', dados.nome);
    // console.log('Materia:', dados.materia);
    // console.log('Nota Unidade 1:', parseFloat(dados.nota1));
    // console.log('Nota Unidade 2:', parseFloat(dados.nota2));
    // console.log('Nota Unidade 3:', parseFloat(dados.nota3));

    this.http.post<any>('http://localhost:5031/Aluno', { Name: dados.nome, materia: dados.materia, NotaUnidade1: parseFloat(dados.nota1), NotaUnidade2: parseFloat(dados.nota2), NotaUnidade3: parseFloat(dados.nota3) }).subscribe(data => {
      data => {
        console.log('POST bem-sucedido:', data);
      }
    })
  }

  verDados() 
    {
      // Simple GET request with response type <any>
      this.http.get<any>('http://localhost:5031/Aluno').subscribe(data => {
        this.Alunos = data;
        // this.totalAngularPackages = data.total;
        // const dados = this.cadastro.value
        // console.log(dados.nome+" " +dados.materia +" " +dados.nota1+" " +dados.nota2 + " "+dados.nota3 + " " + dados.conceito)
        this.Alunos.forEach(aluno => {
          console.log('Nome: ', aluno.name);
          console.log('Matéria: ', aluno.materia);
          console.log('Nota1: ', aluno.notaUnidade1);
          console.log('Nota2: ', aluno.notaUnidade2);
          console.log('Nota3: ', aluno.notaUnidade3);
          console.log('Conceito: ', aluno.conceito);
          // Aqui você pode acessar outros campos do aluno, se necessário
        });
      })
    }



    title = 'ImersaoDevFront';
  }


